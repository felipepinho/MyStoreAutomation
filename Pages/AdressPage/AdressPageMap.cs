using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.AdressPage
{
    public class AdressPageMap : Driver
    {
        protected IWebElement BtnProceedToCheckout
        {
            get
            {
                string element = "//button[@name='processAddress']//span[contains(text(),'Proceed to checkout')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
