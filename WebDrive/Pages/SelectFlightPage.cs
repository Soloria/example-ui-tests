

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class SelectFlightPage : AbstractPage
    {
       public SelectFlightPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.TagName, Using ="img")]
        private IWebElement HeaderImage { get; [UsedImplicitly] set; }


    }
}
