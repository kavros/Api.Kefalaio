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
            var vatValueToCategory= new Dictionary<double, int>()
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
                       select new InvoiceRowType
                       {

                           lineNumber = 1,
                           netValue = (decimal)strn.StValue,
                           vatAmount = (decimal)strn.StFpaVal,
                           vatCategory = vatValueToCategory[(double)vat.FpaData],
                            quantity = (decimal) strn.StQuant,
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

            var list = (await data.ToListAsync());

            MyData.ApiLib.Api.Initialize(_credentials.Url, true);
            Console.WriteLine(_credentials.Url);

            var invoices = new InvoicesDoc()
            {
                invoice = [GetInvoice()]
            };
            var response = await MyData.ApiLib.Api.SendInvoiceList(_credentials.User, _credentials.Key, invoices);

            Console.WriteLine(response.response[0].qrUrl);

            //TODO: save response

        }

        private AadeBookInvoiceType GetInvoice()
        {
            return new AadeBookInvoiceType()
            {
                issuer = new PartyType()
                {
                    vatNumber = "113173996",
                    country = CountryType.GR,
                    branch = 0
                },
                counterpart = new()
                {
                    address = new()
                    {
                        city = "Chania",
                        postalCode = "12345",
                    },
                    vatNumber = "155818615",
                    country = CountryType.GR,
                    branch = 0
                },
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
                        amount = 1860,
                        paymentMethodInfo = "Payment Method Info...",
                        type = 3 //Μετρητα
                    }
                },
                invoiceDetails = [
                    new()
                    {
                        lineNumber = 1,
                        netValue = 1000,
                        vatAmount = 240,
                        vatCategory = 1,//??
                        quantity = 1,
                        discountOption = true, //??
                        incomeClassification = [
                            new()
                            {
                                classificationType = IncomeClassificationValueType.E3_561_001,
                                classificationCategory = IncomeClassificationCategoryType.category1_2,
                                amount = 1000,

                            }
                        ]
                    },
                    new()
                    {
                        lineNumber = 2,
                        netValue = 500,
                        vatAmount = 120,
                        vatCategory = 1,//??
                        quantity = 1,
                        discountOption = true, //??
                        incomeClassification = [
                            new()
                            {
                                classificationType = IncomeClassificationValueType.E3_561_001,
                                classificationCategory = IncomeClassificationCategoryType.category1_2,
                                amount = 500,
                            }
                        ]
                    },
                ],
                invoiceSummary = new()
                {
                    totalNetValue = 1500,
                    totalVatAmount = 360,
                    totalGrossValue = 1860,
                    incomeClassification = [
                         new()
                         {
                             classificationType = IncomeClassificationValueType.E3_561_001,
                             classificationCategory = IncomeClassificationCategoryType.category1_2,
                             amount = 1500,

                         }
                    ]
                }

            };

        }
    }
}
