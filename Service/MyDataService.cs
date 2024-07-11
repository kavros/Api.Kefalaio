using Api.Kefalaio.Model;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyData.Xsd;
using Services.Models;

namespace Services
{
    public class MyDataService : IMyDataService
    {
        private readonly MyDataConnection _credentials;
        private readonly KefalaioContext _dbContext;
        public MyDataService(IOptions<MyDataConnection> configuration, KefalaioContext kefalaioContext) 
        {
            _credentials = configuration.Value;
            _dbContext = kefalaioContext;

        }

        public async Task SendInvoice()
        {
            var customerCode = "22";//TODO: will be passed as a parameter
            var invoiceId = "TΔA000005"; //TODO: will be passed as a parameter
           
            

            MyData.ApiLib.Api.Initialize(_credentials.Url, true);
            Console.WriteLine(_credentials.Url);

            var invoices = new InvoicesDoc()
            {
                invoice = [await GetInvoice(customerCode, invoiceId)]
            };
            var response = await MyData.ApiLib.Api.SendInvoiceList(_credentials.User, _credentials.Key, invoices);

            Console.WriteLine(response.response[0].qrUrl);
            Console.WriteLine(response.response[0].invoiceUid);
            //Console.WriteLine(response.response[0].invoiceMark);


            //TODO: save response
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
            var value =  new AadeBookInvoiceType()
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
