

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class BookFlightPage : AbstractPage
    {
        public BookFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.Name, Using = "passFirst0")]
        private IWebElement FirstNameField { get; [UsedImplicitly] set; }
    }
}
