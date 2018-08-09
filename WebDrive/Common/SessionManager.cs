﻿
namespace WebDrive
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public static class SessionManager
    {
        private static IWebDriver _driver;

        public static void Open(string text)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = text;
        }

        public static void Close()
        {
            _driver.Quit();
        }

        public static IWebDriver getDriver() => _driver;
    }
}