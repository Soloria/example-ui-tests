

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;
    using OpenQA.Selenium.Support.UI;

    public class FlightFinderPage : AbstractPage
    {
        public FlightFinderPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "img[src*='mast_flightfinder']")]
        public IWebElement FlightFinderHeader { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[type='radio'][value='oneway'])")]
        private IWebElement OneWayTripType { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "passCount")]
        private IWebElement Passengers { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        private IWebElement DepartingFrom { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        private IWebElement Months { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        private IWebElement Days { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        private IWebElement ArrivingIn { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="(input[type='radio'][value='Business'")]
        private IWebElement BusinessServiceClass { get; [UsedImplicitly] set; }

        [FindsBy (How = How.Name, Using ="airline")]
        private IWebElement Airlines { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="findFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }


        public FlightFinderPage ChooseOnewWayTripType()
        {
            OneWayTripType.Click();
            return this;
        }

        public FlightFinderPage ChoosePassengersCount(string number)
        {
            var PassengersCount = new SelectElement(Passengers);
            PassengersCount.SelectByValue(number);
            return this;
        }

        public FlightFinderPage ChooseDepartingFrom(string port)
        {
            var Port = new SelectElement(DepartingFrom);
            Port.SelectByValue(port);
            return this;
        }

        public FlightFinderPage ChooseMonth(string month)
        {
            var Month = new SelectElement(Months);
            Month.SelectByValue(month);
            return this;
        }

        public FlightFinderPage ChooseDay(string day)
        {
            var Day = new SelectElement(Days);
            Day.SelectByValue(day);
            return this;
        }

        public FlightFinderPage ChooseArrivingIn(string port)
        {
            var Port = new SelectElement(ArrivingIn);
            Port.SelectByValue(port);
            return this;
        }

        public FlightFinderPage ChooseBusinessClass()
        {
            BusinessServiceClass.Click();
            return this;
        }

        public FlightFinderPage ChooseAirline(string airline)
        {
            var Airline = new SelectElement(Airlines);
            Airline.SelectByValue(airline);
            return this;
        }

        public BookFlightPage ClickContinueButton()
        {
            ContinueButton.Click();
            return new BookFlightPage(SessionManager.getDriver());
        }
    }
}
