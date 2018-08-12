

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

        [FindsBy(How = How.CssSelector, Using ="input[value='oneway']")]
        private IWebElement OneWayTripType { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "passCount")]
        private IWebElement Passengers { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        private IWebElement DepartingFrom { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        private IWebElement MonthsOn { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        private IWebElement DaysOn { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        private IWebElement ArrivingIn { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "toMonth")]
        private IWebElement ReturningMonths { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using = "toDay")]
        private IWebElement ReturningDays { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using ="input[value='Business']")]
        private IWebElement BusinessServiceClass { get; [UsedImplicitly] set; }

        [FindsBy (How = How.Name, Using ="airline")]
        private IWebElement Airlines { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Name, Using ="findFlights")]
        private IWebElement ContinueButton { get; [UsedImplicitly] set; }


        public FlightFinderPage ChooseOneWayTripType()
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

        public FlightFinderPage ChooseMonthOn(string month)
        {
            var Month = new SelectElement(MonthsOn);
            Month.SelectByValue(month);
            return this;
        }

        public FlightFinderPage ChooseDayOn(string day)
        {
            var Day = new SelectElement(DaysOn);
            Day.SelectByValue(day);
            return this;
        }

        public FlightFinderPage ChooseArrivingIn(string port)
        {
            var Port = new SelectElement(ArrivingIn);
            Port.SelectByValue(port);
            return this;
        }

        public FlightFinderPage ChooseReturningMonth(string month)
        {
            var Month = new SelectElement(ReturningMonths);
            Month.SelectByValue(month);
            return this;
        }

        public FlightFinderPage ChooseReturningDay(string day)
        {
            var Day = new SelectElement(ReturningDays);
            Day.SelectByValue(day);
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
            Airline.SelectByText(airline);
            return this;
        }

        public BookFlightPage ClickContinueButton()
        {
            ContinueButton.Click();
            return new BookFlightPage(SessionManager.getDriver());
        }
    }
}
