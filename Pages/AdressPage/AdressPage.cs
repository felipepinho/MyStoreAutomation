using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.AdressPage
{
    public class AdressPage : AdressPageMap
    {
        public void ProceedToCheckoutButton()
        {
            try
            {
                Helper.WaitElementClickable(BtnProceedToCheckout);
                BtnProceedToCheckout.Click();
                Helper.ShowSuccess("Proceeded to checkout.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
