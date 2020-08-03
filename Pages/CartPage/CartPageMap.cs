using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.CartPage
{
    public class CartPageMap : Driver
    {
        protected IWebElement BtnProceedToCheckout
        {
            get
            {
                string element = "//span[contains(text(),'Proceed to checkout')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
