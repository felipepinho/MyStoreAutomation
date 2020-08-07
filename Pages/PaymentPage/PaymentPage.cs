using MyStoreAutomation.Data;
using MyStoreAutomation.Util;
using System;

namespace MyStoreAutomation.Pages.PaymentPage
{
    public class PaymentPage : PaymentPageMap
    {
        public void PaymentButton(ClientInfo clientInfo)
        {
            try
            {
                if (clientInfo.TypeOfPayment == "BankWire")
                {
                    Helper.WaitElementClickable(BtnPayByBankWire);
                    BtnPayByBankWire.Click();
                }
                else
                {
                    Helper.WaitElementClickable(BtnPayByCheck);
                    BtnPayByBankWire.Click();
                }

                BtnIConfirmMyOrder.Click();
                Helper.ShowSuccess("Payment confirmed.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
