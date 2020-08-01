using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.ProductPage
{
    public class ProductPageMap : Driver
    {
        protected IWebElement BtnAddToCart
        {
            get
            {
                string element = "Submit";
                Helper.WaitElement(By.Name(element), 10);
                return WebDriver.FindElement(By.Name(element));
            }
        }

        protected IWebElement TxtQuantity
        {
            get
            {
                string element = "qty";
                Helper.WaitElement(By.Id(element), 10);
                return WebDriver.FindElement(By.Id(element));
            }
        }

        protected IWebElement CmbSize
        {
            get
            {
                string element = "group1";
                Helper.WaitElement(By.Id(element), 10);
                return WebDriver.FindElement(By.Id(element));
            }
        }
    }
}
