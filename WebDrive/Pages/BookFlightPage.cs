

namespace WebDrive
{
    using System.Net.WebSockets;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class BookFlightPage : AbstractPage
    {
        public BookFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.Name, Using = "passFirst0")]
        private IWebElement FirstNameField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="passLast0")]
        private IWebElement LastNameField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="pass.0.meal")]
        private IWebElement Meal { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="creditCard")]
        private IWebElement CardType { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="creditnumber")]
        private IWebElement CardNumber { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "cc_exp_dt_mn")]
        private IWebElement ExpireMonth { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "cc_exp_dt_yr")]
        private IWebElement ExpireYear { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "cc_frst_name")]
        private IWebElement CardHolderFirstName { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "cc_mid_name")]
        private IWebElement CardHolderMiddleName { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "cc_last_name")]
        private IWebElement CardHolderLastName { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "billAddress1")]
        private IWebElement AddressOne { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "billAddress2")]
        private IWebElement AddressTwo { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delCity")]
        private IWebElement City { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delState")]
        private IWebElement State { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delZip")]
        private IWebElement PostalCode { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delCountry")]
        private IWebElement Country { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "buyFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }


    }
}
