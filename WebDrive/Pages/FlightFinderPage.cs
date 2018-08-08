

namespace WebDrive
{
    using System.Linq;
    using System.Runtime.CompilerServices;
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

        public string HeaderText => HeaderImage.GetAttribute("src").Split("/").LastOrDefault();
    }
}
