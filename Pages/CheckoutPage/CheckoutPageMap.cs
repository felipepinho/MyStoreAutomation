using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.CheckoutPage
{
    public class CheckoutPageMap : Driver
    {
        protected IWebElement BtnProceedToCheckout
        {
            get
            {
                string element = "//a[@class='button btn btn-default standard-checkout button-medium']//span[contains(text(),'Proceed to checkout')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
