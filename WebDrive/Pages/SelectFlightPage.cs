

namespace WebDrive
{
    using System.Linq;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class SelectFlightPage : AbstractPage
    {
       public SelectFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.TagName, Using ="img")]
        private IWebElement HeaderImage { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[name='outFlight'][value^='Unified Airlines$361'])")]
        private IWebElement OutUnifiedAirlines363 { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[name='inFlight'][value^='Blue Skies Airlines$631])")]
        private IWebElement InBlueSkiesAirlines631 { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="reserveFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }

        public string HeaderText => HeaderImage.GetAttribute("src").Split("/").LastOrDefault();
    }
}
