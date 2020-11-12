using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyAutomationFramework
{
    public class HomePage : NavigatablePage
    {
        public IWebDriver driver;

        [FindsBy(How = How.XPath, Using = @"//a[text()='Login']")]
        public IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = @"//a[text()='Register']")]
        public IWebElement RegisterButton { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public override string GetUrl() => this.WrappedDriver.Url;
        public void PressLoginButton() => LoginButton.Click();
        public void PressRegisterButton() => RegisterButton.Click();
        


    }
}
