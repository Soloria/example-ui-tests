

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;
    using OpenQA.Selenium.Support.UI;

    public class BookFlightPage : AbstractPage
    {
        public BookFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "img[src*='mast_book'")]
        public IWebElement BookAFlightHeader { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "passFirst0")]
        private IWebElement FirstNameField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="passLast0")]
        private IWebElement LastNameField { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="pass.0.meal")]
        private IWebElement Meals { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="creditCard")]
        private IWebElement CardTypes { get; [UsedImplicitly] set; }

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
        private IWebElement FirstBillingAddress { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "billAddress2")]
        private IWebElement SecondBillingAddress { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delCity")]
        private IWebElement City { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delState")]
        private IWebElement State { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delZip")]
        private IWebElement PostalCode { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "delCountry")]
        private IWebElement Countries { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "buyFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }

        public BookFlightPage InputFirstName(string firstname)
        {
            FirstNameField.Click();
            FirstNameField.SendKeys(firstname);
            return this;
        }

        public BookFlightPage InputLastName(string lastname)
        {
            LastNameField.Click();
            LastNameField.SendKeys(lastname);
            return this;
        }

        public BookFlightPage ChooseMealPreference(string meal)
        {
            var Meal = new SelectElement(Meals);
            Meal.SelectByValue(meal);
            return this;
        }

        public BookFlightPage ChooseCardType(string card)
        {
            var Card = new SelectElement(CardTypes);
            Card.SelectByValue(card);
            return this;
        }

        public BookFlightPage InputCardNumber(string number)
        {
            CardNumber.Click();
            CardNumber.SendKeys(number);
            return this;
        }

        public BookFlightPage ChooseExpirationMonth(string month)
        {
            var Month = new SelectElement(ExpireMonth);
            Month.SelectByValue(month);
            return this;
        }

        public BookFlightPage ChooseExpirationYear(string year)
        {
            var Year = new SelectElement(ExpireYear);
            Year.SelectByValue(year);
            return this;
        }

        public BookFlightPage InputCardHolderFirstName(string firstname)
        {
            CardHolderFirstName.Click();
            CardHolderFirstName.SendKeys(firstname);
            return this;
        }

        public BookFlightPage InputCardHolderMiddleName(string middlename)
        {
            CardHolderMiddleName.Click();
            CardHolderMiddleName.SendKeys(middlename);
            return this;
        }

        public BookFlightPage InputCardHolderLastName(string lastname)
        {
            CardHolderLastName.Click();
            CardHolderLastName.SendKeys(lastname);
            return this;
        }

        public BookFlightPage InputFirstBillingAddress(string firstAddress)
        {
            FirstBillingAddress.Click();
            FirstBillingAddress.SendKeys(firstAddress);
            return this;
        }

        public BookFlightPage InputSecondBillinfAddress(string secondAddress)
        {
            SecondBillingAddress.Click();
            SecondBillingAddress.SendKeys(secondAddress);
            return this;
        }

        public BookFlightPage InputCity(string city)
        {
            City.Click();
            City.SendKeys(city);
            return this;
        }

        public BookFlightPage InputState(string state)
        {
            State.Click();
            State.SendKeys(state);
            return this;
        }

        public BookFlightPage InputPostalCode(string postalcode)
        {
            PostalCode.Click();
            PostalCode.SendKeys(postalcode);
            return this;
        }

        public BookFlightPage ChooseCountry(string country)
        {
            var Country = new SelectElement(Countries);
            Country.SelectByValue(country);
            return this;
        }

        public FlightConfirmationPage ClickContinueButton()
        {
            ContinueButton.Click();
            return new FlightConfirmationPage(SessionManager.getDriver());
        }
    }
}
