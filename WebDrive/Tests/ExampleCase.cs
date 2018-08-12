namespace WebDrive
{
   
    using NUnit.Framework;

    public class ExampleCase
    {
        [OneTimeSetUp]
        public static void Start() => SessionManager.Open(SessionManager.Path);

        [Test]
        [Order(order: 1)]
        public void LogIn()
        {
            new MainPage(SessionManager.getDriver())
                .InputName(Config.GetValue<string>("username"))
                .InputPassword(Config.GetValue<string>("password"))
                .ClickLoginButton();
            Assert.IsTrue(new FlightFinderPage(SessionManager.getDriver()).FlightFinderHeader.Displayed);
        }

        [Test]
        [Order(order: 2)]
        public void EnterFlightDetails()
        {
            new FlightFinderPage(SessionManager.getDriver())
                .ChooseOneWayTripType()
                .ChoosePassengersCount("2")
                .ChooseDepartingFrom("Paris")
                .ChooseMonthOn("11")
                .ChooseDayOn("20")
                .ChooseArrivingIn("Seattle")
                .ChooseReturningMonth("12")
                .ChooseReturningDay("19")
                .ChooseBusinessClass()
                .ChooseAirline("Pangea Airlines")
                .ClickContinueButton();
            Assert.IsTrue(new SelectFlightPage(SessionManager.getDriver()).HeaderBookAFlight.Displayed);
        }

        [OneTimeTearDown]
        public static void Clean() => SessionManager.Close();
    }
}
