

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class SelectFlightPage : AbstractPage
    {
       public SelectFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "img[src*='mast_selectflight']")]
        public IWebElement SelectFlightHeader { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="input[name='outFlight'][value*='Unified Airlines$363']")]
        private IWebElement OutUnifiedAirlines363 { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="input[name='inFlight'][value*='Blue Skies Airlines$631']")]
        private IWebElement InBlueSkiesAirlines631 { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="reserveFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }

        public SelectFlightPage ChooseOutFlight()
        {
            OutUnifiedAirlines363.Click();
            return this;
        }

        public SelectFlightPage ChooseInFlight()
        {
            InBlueSkiesAirlines631.Click();
            return this;
        }

        public BookFlightPage ClickContinueButton()
        {
            ContinueButton.Click();
            return new BookFlightPage(SessionManager.getDriver());
        }
    }
}
