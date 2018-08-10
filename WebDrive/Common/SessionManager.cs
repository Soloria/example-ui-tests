
namespace WebDrive
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public static class SessionManager
    {
        private static IWebDriver _driver;

        public static void Open(string text)
        {
            Config.StartUp();
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = text;
        }

        public static void Close()
        {
            _driver.Quit();
        }

        public static string Path = "http://newtours.demoaut.com/";

        public static IWebDriver getDriver() => _driver;
    }
}
