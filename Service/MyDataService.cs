using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using MyData.Xsd;
using Services.Models;
using System.Reflection.Metadata;

namespace Services
{
    public class MyDataService : IMyDataService
    {
        private readonly KefalaioContext _dbContext;
        public MyDataService(KefalaioContext kefalaioContext)
        {
            _dbContext = kefalaioContext;

        }

        public async Task<IList<Invoice>> GetAllInvoices()
        {
            var res = (from cm in _dbContext.Cmasts
                       join strn in _dbContext.Strns on cm.CCode equals strn.StCustSuppl
                       where strn.StTransKind == 35
                       orderby strn.StDoc
                       select new Invoice()
                       {
                           DocumentId = strn.StDoc,
                           CustomerId = cm.CCode
                       }).AsEnumerable()
                      .DistinctBy(x => x.DocumentId);
            return res.ToList();
        }

        public async Task<SendInvoiceResponse> SendInvoice(Invoice invoice)
        {
            var existing = await _dbContext.InvoiceMappings
                .FirstOrDefaultAsync(x => invoice.DocumentId == x.DocumentId);
            if (existing != null)
            {
                return new SendInvoiceResponse()
                {
                    CustomerDetails = await GetCustomerDetails(invoice.CustomerId),
                    InvoiceRows = await GetInvoice(invoice.DocumentId),
                    MyDataDetails = new MyDataDetails()
                    {
                        InvoiceMark = existing.InvoiceMark,
                        QRUrl = existing.QRUrl,
                        PaymentMethod = "Μετρητά",
                        CreatedDate = existing.SentDate,
                    }

                };
            }
            var credentials = await _dbContext.MyDataCredentials.FirstOrDefaultAsync();
            MyData.ApiLib.Api.Initialize(credentials.Url, true);
            var invoiceData = await GetInvoice(invoice.CustomerId, invoice.DocumentId);
            var invoices = new InvoicesDoc()
            {
                invoice = [invoiceData]
            };
            //send invoice to mydata
            var response = await MyData.ApiLib.Api.SendInvoiceList(credentials.User, credentials.Key, invoices);

            //save response
            var currentDate = DateTime.Now;
            await _dbContext.InvoiceMappings.AddAsync(new InvoiceMappings()
            {
                DocumentId = invoice.DocumentId,
                QRUrl = response.response[0].qrUrl,
                InvoiceMark = response.response[0].invoiceMark,
                SentDate = currentDate
            });
            await _dbContext.SaveChangesAsync();

            //return UI data
            return new SendInvoiceResponse()
            {
                CustomerDetails = await GetCustomerDetails(invoice.CustomerId),
                InvoiceRows = await GetInvoice(invoice.DocumentId),
                MyDataDetails = new MyDataDetails()
                {
                    InvoiceMark = response.response[0].invoiceMark,
                    QRUrl = response.response[0].qrUrl,
                    CreatedDate = currentDate,
                    PaymentMethod = "Μετρητά"
                }

            };
        }
        public async Task<IList<string>> GetMyDataInvoices()
        {
            return await _dbContext.InvoiceMappings.Select(x => x.DocumentId).ToListAsync();
        }
        public async Task<string?> CancelInvoice(string documentId)
        {
            var credentials = await _dbContext.MyDataCredentials.FirstOrDefaultAsync();
            var mappings = await _dbContext.InvoiceMappings.FirstOrDefaultAsync(x => documentId == x.DocumentId);
            if(mappings == null)
            {
                return "Document id cannot be found.";
            }
            MyData.ApiLib.Api.Initialize(credentials.Url, true);
            
            var response = await MyData.ApiLib.Api.CancelInvoice(credentials.User, credentials.Key, mappings.InvoiceMark.ToString());
            if (response?.response.FirstOrDefault()?.cancellationMark != null)
            {
                _dbContext.Remove(mappings);
                await _dbContext.SaveChangesAsync();
                return null;
            }

            var errors = response?.response
                                .FirstOrDefault()
                                ?.errors?.error
                                ?.FirstOrDefault()?.message;
            return errors;
        }
        private async Task<List<InvoiceRow>> GetInvoice(string invoiceId)
        {

            var data = from strn in _dbContext.Strns
                       join sm in _dbContext.Smasts on strn.SFileId equals sm.SFileId
                       join vat in _dbContext.Vats on strn.StVatid equals vat.FpaId
                       where strn.StTransKind == 35 && strn.StDoc == invoiceId
                       orderby strn.SFileId
                       select new InvoiceRow()
                       {
                           Code = sm.SCode,
                           Description = sm.SName,
                           Quantity = strn.StQuant,
                           MM = sm.SUnitOm,
                           Price = strn.StPrice,
                           Discount = strn.StDiscount,
                           NetValue = (strn.StValue != null ? double.Round((double)strn.StValue, 2) : 0),
                           Vat = vat.FpaData,
                           VatAmount = strn.StFpaVal != null ? double.Round((double)strn.StFpaVal, 2) : 0,
                           Amount = (strn.StFpaVal != null ? double.Round((double)strn.StFpaVal, 2) : 0) +
                                     (strn.StValue != null ? double.Round((double)strn.StValue, 2) : 0)
                       };

            return await data.ToListAsync();
        }
        private async Task<CustomerDetails> GetCustomerDetails(string customerCode)
        {
            var res = from cm in _dbContext.Cmasts
                      where cm.CCode == customerCode
                      select new CustomerDetails()
                      {
                          Address = cm.CAddress11,
                          Name = cm.CName,
                          VatNumber = cm.CVatno
                      };
            return await res.FirstAsync();
        }
        private async Task<AadeBookInvoiceType> GetInvoice(string customerCode, string invoiceId)
        {
            var vatValueToCategory = new Dictionary<double, int>()
            {
                { 24, 1 },
                { 13, 2 },
                { 6, 3 },
                { 17, 4 },
                { 9, 5 },
                { 4, 6 },
                { 0, 7 },
                { 3, 9 }
            };

            var customerDetails = from cm in _dbContext.Cmasts
                                  where cm.CCode == customerCode
                                  select new PartyType()
                                  {
                                      vatNumber = cm.CVatno,
                                      address = new()
                                      {
                                          street = cm.CAddress11,
                                          postalCode = cm.CZipCode1,
                                          city = cm.CArea1
                                      },
                                      country = CountryType.GR,
                                      branch = 0
                                  };

            var data = from strn in _dbContext.Strns
                       join sm in _dbContext.Smasts on strn.SFileId equals sm.SFileId
                       join vat in _dbContext.Vats on strn.StVatid equals vat.FpaId
                       where strn.StTransKind == 35 && strn.StDoc == invoiceId
                       orderby strn.SFileId
                       select new InvoiceRowType
                       {
                           lineNumber = 1,
                           netValue = (decimal)strn.StValue,
                           vatAmount = (decimal)strn.StFpaVal,

                           vatCategory = vatValueToCategory[(double)vat.FpaData],
                           quantity = (decimal)strn.StQuant,
                           discountOption = true, //??
                           incomeClassification = new List<IncomeClassificationType>()
                            {
                                new()
                                {
                                    classificationType = IncomeClassificationValueType.E3_561_001,
                                    classificationCategory = IncomeClassificationCategoryType.category1_2,
                                    amount = (decimal) strn.StValue,
                                }
                            }
                       };

            var linenumber = 1;
            var invoiceDetails = (await data.ToListAsync());
            invoiceDetails.ForEach(x => x.lineNumber = linenumber++);
            var customer = await customerDetails.FirstAsync();
            var value = new AadeBookInvoiceType()
            {
                issuer = new PartyType()
                {
                    vatNumber = "113173996",
                    country = CountryType.GR,
                    branch = 0
                },
                counterpart = customer,
                invoiceHeader = new()
                {
                    series = "A",
                    aa = "101", //TODO: set the correct value
                    issueDate = DateTime.Now,
                    invoiceType = InvoiceType.Item1Period1,
                    currency = CurrencyType.EUR,
                },
                paymentMethods = new List<PaymentMethodDetailType>() {

                    new PaymentMethodDetailType()
                    {
                        amount = invoiceDetails.Sum(x=> x.netValue + x.vatAmount),
                        paymentMethodInfo = "Payment Method Info...",
                        type = 3 //Μετρητα
                    }
                },
                invoiceDetails = invoiceDetails,
                invoiceSummary = new()
                {
                    totalNetValue = invoiceDetails.Sum(x => x.netValue),
                    totalVatAmount = invoiceDetails.Sum(x => x.vatAmount),
                    totalGrossValue = invoiceDetails.Sum(x => x.netValue + x.vatAmount),
                    incomeClassification = [
                         new()
                         {
                             classificationType = IncomeClassificationValueType.E3_561_001,
                             classificationCategory = IncomeClassificationCategoryType.category1_2,
                             amount = invoiceDetails.Sum(x => x.netValue),

                         }
                    ]
                }

            };

            return value;

        }
    }
}
