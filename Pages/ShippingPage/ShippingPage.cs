using MyStoreAutomation.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreAutomation.Pages.ShippingPage
{
    public class ShippingPage : ShippingPageMap
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

        public void TermsOfServiceCheck()
        {
            try
            {
                Helper.WaitElementClickable(ChkTermsOfService);
                ChkTermsOfService.Click();
                Helper.ShowSuccess("Terms of Service has been marked.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
