﻿namespace WebDrive
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

        [OneTimeTearDown]
        public static void Clean() => SessionManager.Close();
    }
}
