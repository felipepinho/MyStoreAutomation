using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.ProductPage
{
    public class ProductPage : ProductPageMap
    {
        public void Navigate(string product = "")
        {
            try
            {
                WebDriver.Navigate().GoToUrl(string.Concat(baseUrl, product));
                Console.WriteLine(string.Format("[{0}] - Product page opened.", DateTime.Now.ToString("HH:mm:ss.fff")));
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }

        public void AddToCartButton()
        {
            try
            {
                var wait = new WebDriverWait(WebDriver, Helper.DefaultTimeout);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BtnAddToCart));
                BtnAddToCart.Click();
                Console.WriteLine(string.Format("[{0}] - Product added to cart.", DateTime.Now.ToString("HH:mm:ss.fff")));
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}