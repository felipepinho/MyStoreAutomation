using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.CartPage
{
    public class CartPage : CartPageMap
    {
        public void ProceedToCheckoutButton()
        {
            try
            {
                var wait = new WebDriverWait(WebDriver, Helper.DefaultTimeout);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BtnProceedToCheckout));
                BtnProceedToCheckout.Click();
                Console.WriteLine(string.Format("[{0}] - Proceeded to checkout.", DateTime.Now.ToString("HH:mm:ss.fff")));
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
