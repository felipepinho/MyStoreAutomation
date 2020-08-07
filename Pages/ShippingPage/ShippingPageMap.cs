using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.ShippingPage
{
    public class ShippingPageMap : Driver
    {
        protected IWebElement BtnProceedToCheckout
        {
            get
            {
                string element = "//button[@name='processCarrier']//span[contains(text(),'Proceed to checkout')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }

        protected IWebElement ChkTermsOfService
        {
            get
            {
                string element = "//label[contains(text(),'I agree to the terms of service and will adhere to')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
