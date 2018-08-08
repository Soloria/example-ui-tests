
namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class MainPage : AbstractPage
    {
        public MainPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement NameField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement PasswordField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement LoginButton { get; [UsedImplicitly] set; }

        public MainPage InputName(string name)
        {
            NameField.Click();
            NameField.Clear();
            NameField.SendKeys(name);
            return this;
        }

        public MainPage InputPassword(string password)
        {
            PasswordField.Click();
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            return this;
        }

        public FlightFinderPage ClickLoginButton()
        {
            LoginButton.Click();
            return new FlightFinderPage(SessionManager.getDriver());
        }
    }
    
}
