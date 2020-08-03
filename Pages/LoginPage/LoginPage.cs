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
                var wait = new WebDriverWait(WebDriver, Helper.DefaultTimeout);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(TxtEmail));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(TxtPassword));
                TxtEmail.SendKeys(clientInfo.Email);
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
                var wait = new WebDriverWait(WebDriver, Helper.DefaultTimeout);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BtnSignIn));
                BtnSignIn.Click();
                Console.WriteLine(string.Format("[{0}] - Login has been successfully.", DateTime.Now.ToString("HH:mm:ss.fff")));
            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
