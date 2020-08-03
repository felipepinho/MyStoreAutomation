using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.CheckoutPage
{
    public class CheckoutPage : CheckoutPageMap
    {
        public void ProceedToCheckoutButton()
        {
            try
            {
                Helper.WaitElementClickable(BtnProceedToCheckout);
                BtnProceedToCheckout.Click();
                Helper.ShowSuccess("Proceeded to login.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
