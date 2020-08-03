using MyStoreAutomation.Data;
using MyStoreAutomation.Util;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStoreAutomation.Pages.LoginPage
{
    public class LoginPage : LoginPageMap
    {
        public void ClientInput(ClientInfo clientInfo)
        {
            try
            {
                Helper.WaitElementClickable(TxtEmail);
                TxtEmail.SendKeys(clientInfo.Email);
                Helper.WaitElementClickable(TxtPassword);
                TxtPassword.SendKeys(clientInfo.Password);
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }

        public void SignInButton()
        {
            try
            {
                Helper.WaitElementClickable(BtnSignIn);
                BtnSignIn.Click();
                Helper.ShowSuccess("Login has been successfully.");
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
