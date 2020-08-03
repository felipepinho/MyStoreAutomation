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
                string element = "/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[2]/form[1]/div[1]/p[2]/button[1]/span[1]";
                Helper.WaitElement(By.XPath(element), 10);
                return WebDriver.FindElement(By.XPath(element));
            }
        }
    }
}
