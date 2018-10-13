namespace WebDrive
{
    using NUnit.Framework;

    public class ExampleCase
    {
        [OneTimeSetUp]
        public static void Start() => SessionManager.Open(SessionManager.Path);

        [Test]
        [Order(order: 0)]
        public void LogIn()
        {
            new MainPage(SessionManager.getDriver())
                .InputName(Config.GetValue<string>("username"))
                .InputPassword(Config.GetValue<string>("password"))
                .ClickLoginButton();
             Assert.IsTrue(new FlightFinderPage(SessionManager.getDriver()).FlightFinderHeader.Displayed);
        }

        [Test]
        [Order(order: 1)]
        public void EnterFlightDetails()
        {
            new FlightFinderPage(SessionManager.getDriver())
                .ChooseOneWayTripType()
                .ChoosePassengersCount("1")
                .ChooseDepartingFrom("Paris")
                .ChooseMonthOn("11")
                .ChooseDayOn("20")
                .ChooseArrivingIn("Seattle")
                .ChooseReturningMonth("12")
                .ChooseReturningDay("19")
                .ChooseBusinessClass()
                .ChooseAirline("Pangea Airlines")
                .ClickContinueButton();
            Assert.IsTrue(new SelectFlightPage(SessionManager.getDriver()).SelectFlightHeader.Displayed);
        }

        [Test]
        [Order(order: 2)]
        public void SelectFlight()
        {
            //TODO: Rework to a more flexible option in terms of choice
            new SelectFlightPage(SessionManager.getDriver())
                .ChooseInFlight()
                .ChooseOutFlight()
                .ClickContinueButton();
            Assert.IsTrue(new BookFlightPage(SessionManager.getDriver()).BookAFlightHeader.Displayed);
        }

        [Test]
        [Order(order: 3)]
        public void BookAFlight()
        {
            //TODO: Move some data to config
            new BookFlightPage(SessionManager.getDriver())
                .InputFirstName("Ivan")
                .InputLastName("Ivanov")
                .ChooseMealPreference("Hindu")
                .ChooseCardType("Visa")
                .InputCardNumber("88005553535")
                .ChooseExpirationMonth("12")
                .ChooseExpirationYear("2007")
                .InputCardHolderFirstName("Ivan")
                .InputCardHolderMiddleName("ivanovich")
                .InputCardHolderLastName("Ivanov")
                .InputFirstBillingAddress("Pushkin's street")
                .InputSecondBillingAddress("Kolotushkin's house")
                .InputCity("Moscow")
                .InputState("CAO")
                .InputPostalCode("14/88")
                .ChooseCountry("UNITED STATES")
                .ClickContinueButton();
            Assert.IsTrue(new FlightConfirmationPage(SessionManager.getDriver()).FlightConfirmationHeader.Displayed);
        }

        //TODO: Flight Confirmation test

        [OneTimeTearDown]
        public static void Clean() => SessionManager.Close();
    }
}
