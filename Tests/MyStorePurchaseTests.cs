using MyStoreAutomation.Config;
using NUnit.Framework;

namespace MyStoreAutomation.Tests
{
    public class MyStorePurchaseTests : Driver
    {
        [SetUp]
        public void BeforeTest()
        {
            StartBrowser(Browser.CHROME_DESKTOP);
        }

        [Test]
        [TestCase()]
        public void Purchase_Blouse()
        {
            var productUrl = "?id_product=2&controller=product";
            var productPrice = "$27.00";
            new PurchaseFacade().PurchaseProduct(productUrl, productPrice);
        }

        [TearDown]
        public void AfterTest()
        {
            StopBrowser();
        }
    }
}
