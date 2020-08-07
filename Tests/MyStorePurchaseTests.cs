using MyStoreAutomation.Config;
using MyStoreAutomation.Data;
using MyStoreAutomation.Util;
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
        [TestCase(TestData.blouse, TestName = "PurchaseTest: Blouse - $27,00")]
        public void PurchaseTest(string productUrl)
        {
            ClientInfo currentClientInfo = new ClientInfo()
            {
                Email = TestData.email,
                Password = TestData.password,
                TypeOfPayment = TestData.type
            };
            new PurchaseFacade().PurchaseProduct(productUrl, currentClientInfo);
        }

        [TearDown]
        public void AfterTest()
        {
            StopBrowser();
        }
    }
}