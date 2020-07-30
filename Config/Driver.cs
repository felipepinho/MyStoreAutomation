using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MyStoreAutomation.Util;
using System;
using System.IO;
using System.Reflection;

namespace MyStoreAutomation.Config
{
    public class Driver
    {
        public static IWebDriver WebDriver;
        private static readonly string baseUrl = "http://automationpractice.com/index.php";

        #region ENUM Browser 
        public enum Browser
        {
            CHROME_MOBILE,
            CHROME_DESKTOP,
            CHROME_HEADLESS
        }
        #endregion

        public static void Initialize(Browser browser)
        {
            try
            {
                switch (browser)
                {
                    case Browser.CHROME_DESKTOP:
                        var chromeDriverExePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var driverService = ChromeDriverService.CreateDefaultService(chromeDriverExePath);
                        driverService.HideCommandPromptWindow = true;
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments("--incognito, --start-maximized");
                        chromeOptions.AddArgument("--disable-popup-blocking");
                        chromeOptions.AddArgument("--allow-insecure-localhost");
                        chromeOptions.AddArgument("--ignore-certificate-errors");
                        WebDriver = new ChromeDriver(driverService, chromeOptions);
                        break;
                    case Browser.CHROME_HEADLESS:
                        var chromeDriverExePathHeadless = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var driverServiceHeadless = ChromeDriverService.CreateDefaultService(chromeDriverExePathHeadless);
                        driverServiceHeadless.HideCommandPromptWindow = true;
                        ChromeOptions chromeOptionsHeadless = new ChromeOptions();
                        chromeOptionsHeadless.AddArguments("headless", "--incognito", "--start-maximized");
                        WebDriver = new ChromeDriver(driverServiceHeadless, chromeOptionsHeadless);
                        break;
                    case Browser.CHROME_MOBILE:
                        var chromeDriverExePathMobile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var driverServiceMobile = ChromeDriverService.CreateDefaultService(chromeDriverExePathMobile);
                        driverServiceMobile.HideCommandPromptWindow = true;
                        ChromeOptions chromeOptionsMobile = new ChromeOptions();
                        chromeOptionsMobile.AddArguments("--incognito", "--start-maximized");
                        chromeOptionsMobile.EnableMobileEmulation("iPhone X");
                        chromeOptionsMobile.AddArgument("--disable-popup-blocking");
                        chromeOptionsMobile.AddArgument("--allow-insecure-localhost");
                        chromeOptionsMobile.AddArgument("--ignore-certificate-errors");
                        WebDriver = new ChromeDriver(driverServiceMobile, chromeOptionsMobile);
                        break;
                }

                WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
                Console.WriteLine(string.Format("[{0}] - Browser [{1}] started", DateTime.Now.ToString("HH:mm:ss.fff"), browser));
                WebDriver.Url = baseUrl;
                Console.WriteLine(string.Format("[{0}] - URL [{1}] opened", DateTime.Now.ToString("HH:mm:ss.fff"), WebDriver.Url));

            }
            catch (Exception e)
            {
                Helper.ShowError(e.Message);
                throw new Exception(e.Message);
            }
        }

        public static void Finalizar() => WebDriver.Quit();
    }
}
