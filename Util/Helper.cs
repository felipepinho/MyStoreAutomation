﻿using MyStoreAutomation.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace MyStoreAutomation.Util
{
    public static class Helper
    {
        public static TimeSpan DefaultTimeout = TimeSpan.FromSeconds(30);

        public static void ShowError(string exception)
        {
            string method = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name;
            string message = string.Format("[{0}] - The method [{1}] caused an exception: ", DateTime.Now.ToString("HH:mm:ss.fff"), method);
            Console.WriteLine(message + exception);
        }

        public static void InputText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void SelectOption(this IList<IWebElement> list, string option)
        {
            foreach (IWebElement element in list)
            {
                if (element.Text.Contains(option))
                {
                    element.Click();
                }
            }
        }

        public static void SelectOptionByText(this IWebElement element, string option)
        {
            new SelectElement(element).SelectByText(option);
        }

        public static void SelectOptionByValue(this IWebElement element, string option)
        {
            new SelectElement(element).SelectByValue(option);
        }

        public static void Scroll(int pixel)
        {
            ((IJavaScriptExecutor)Driver.WebDriver).ExecuteScript("window.scrollTo(0, " + pixel + ")");
        }

        public static void ScrollAndClick(this IWebElement element)
        {
            Actions action = new Actions(Driver.WebDriver);
            action.MoveToElement(element);
            action.Click();
            action.Perform();
        }

        public static void Tab()
        {
            Actions action = new Actions(Driver.WebDriver);
            action.SendKeys(Keys.Tab).Build().Perform();
        }

        public static void WaitElement(By by, int time)
        {
            var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}