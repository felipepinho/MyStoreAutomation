using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.PaymentPage
{
    public class PaymentPageMap : Driver
    {
        protected IWebElement BtnPayByBankWire
        {
            get
            {
                string element = "bankwire";
                Helper.WaitElement(By.ClassName(element), 10);
                return WebDriver.FindElement(By.ClassName(element));
            }
        }

        protected IWebElement BtnPayByCheck
        {
            get
            {
                string element = "cheque";
                Helper.WaitElement(By.ClassName(element), 10);
                return WebDriver.FindElement(By.ClassName(element));
            }
        }

        protected IWebElement BtnIConfirmMyOrder
        {
            get
            {
                string element = "//span[contains(text(),'I confirm my order')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }

        
    }
}
