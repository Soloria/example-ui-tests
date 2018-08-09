

namespace WebDrive
{
    using System.Linq;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class FlightFinderPage : AbstractPage
    {
        public FlightFinderPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.TagName, Using ="img")]
        private IWebElement HeaderImage { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[type='radio'][value='oneway'])")]
        private IWebElement OneWayTripType { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "passCount")]
        private IWebElement PassengersCount { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        private IWebElement DepartingFrom { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        private IWebElement Month { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        private IWebElement Day { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        private IWebElement ArrivingIn { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[type='radio'][value='Business'")]
        private IWebElement BusinessServiceClass { get; [UsedImplicitly] set; }

        [FindsBy (How = How.Name, Using ="airline")]
        private IWebElement Airline { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="findFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }

        public string HeaderText => HeaderImage.GetAttribute("src").Split("/").LastOrDefault();
    }
}
