using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.ProductPage
{
    public class ProductPage : ProductPageMap
    {
        public void NavigateTo(string product)
        {
            try
            {
                WebDriver.Navigate().GoToUrl(string.Concat(baseUrl, product));
                Helper.ShowSuccess("Product page opened.");
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
                Helper.WaitElementClickable(BtnAddToCart);
                BtnAddToCart.Click();
                Helper.ShowSuccess("Product added to cart.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}