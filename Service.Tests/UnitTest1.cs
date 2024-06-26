using Api.Kefalaio.Model;
using Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using Services;
using System.Text;
using System.Text.RegularExpressions;

namespace Service.Tests
{
    public class OrdersServiceTests
    {
        [Fact]
        public async Task GetSuppliers_ReturnsSuppliersOrderedByName()
        {
            var a = "prd%5Bafm%5D=&prd%5BproductType%5D=1&prd%5BproductCategory%5D=0&prd%5BproductCode%5D=2100&prd%5BtaricCode%5D=&prd%5BproductDescription%5D=A%CE%93%CE%93%CE%9F%CE%A5%CE%A1%CE%99%CE%91&prd%5BunitPrice%5D=0&prd%5BvatCategory%5D=2&prd%5Bunit%5D=&prd%5BOtherMeasurementUnitTitle%5D=&prd%5BOtherMeasurementUnitQuantity%5D=&prd%5BspecialType%5D=&prd%5BfeesWithVAT%5D=&prd%5BotherTaxesWithVAT%5D=";
            var decodedString = System.Web.HttpUtility.UrlDecode(a);
            Console.WriteLine(decodedString);
            var encodedString= System.Web.HttpUtility.UrlEncode(decodedString, Encoding.UTF8);
            encodedString = encodedString
                            .Replace("%3d", "=")
                            .Replace("%26", "&");
            var b = Uri.EscapeDataString(decodedString);
            b = b.Replace("%3D", "=")
                 .Replace("%26", "&");
            encodedString = Regex.Replace(encodedString, @"%[a-f\d]{2}", m => m.Value.ToUpper());

            Assert.Equal(a, encodedString);
            Assert.Equal(a, b);
            /*  var suppliers = new List<Pmast>
              {
                  new Pmast { PName = "Supplier 2", PCode = "S2"},
                  new Pmast { PName = "Supplier 1", PCode = "S1"}
              };

              var mockContext = new Mock<KefalaioContext>();
              mockContext.Setup(c => c.Pmasts).Returns(suppliers);

              var service = new OrdersService(mockContext.Object);
              var results = await service.GetSuppliers();

              Assert.Equal(suppliers[0].PCode, results[0].Code);*/

        }
    }

}