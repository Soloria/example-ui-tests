﻿

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class FlightConfirmationPage : AbstractPage
    {
        public FlightConfirmationPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using= "(img[src*='mast_confirmation'])")]
        private IWebElement FlightConfirmationHeader { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(img[src*='backtoflights'])")]
        private IWebElement BackToFlightsButton { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(img[src*='home'])")]
        private IWebElement BackToHomeButton { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(img[src*='Logout'])")]
        private IWebElement LogoutButton { get; [UsedImplicitly] set; }

    }
}