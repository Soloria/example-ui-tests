

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class SignOnPage : AbstractPage
    {
        public SignOnPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "img[src*='mast_signon']")]
        private IWebElement SignOnHeader { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement Username { get; [UsedImplicitly] set; }
        
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement SubmitButton { get; [UsedImplicitly] set; }

        public SignOnPage InputUsername(string name)
        {
            Username.Click();
            Username.SendKeys(name);
            return this;
        }

        public SignOnPage InputPassword(string pass)
        {
            Password.Click();
            Password.SendKeys(pass);
            return this;
        }

        public FlightFinderPage ClickSubmitButton()
        {
            SubmitButton.Click();
            return new FlightFinderPage(SessionManager.getDriver());
        }
    }
}
