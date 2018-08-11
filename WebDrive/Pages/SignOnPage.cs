

namespace WebDrive
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class SignOnPage : AbstractPage
    {
        public SignOnPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "img[src*='mast_signon']")]
        private IWebElement SignOnHeader { get; [UsedImplicitly] set; }
    }
}
