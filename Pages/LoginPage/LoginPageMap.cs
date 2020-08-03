using MyStoreAutomation.Config;
using MyStoreAutomation.Util;
using OpenQA.Selenium;

namespace MyStoreAutomation.Pages.LoginPage
{
    public class LoginPageMap : Driver
    {
        protected IWebElement TxtEmail
        {
            get
            {
                string element = "email";
                Helper.WaitElement(By.Id(element), 10);
                return WebDriver.FindElement(By.Id(element));
            }
        }

        protected IWebElement TxtPassword
        {
            get
            {
                string element = "passwd";
                Helper.WaitElement(By.Id(element), 10);
                return WebDriver.FindElement(By.Id(element));
            }
        }

        protected IWebElement BtnSignIn
        {
            get
            {
                string element = "//span[contains(text(),'Sign in')]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
