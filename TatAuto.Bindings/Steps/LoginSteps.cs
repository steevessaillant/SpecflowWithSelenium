using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAutomationFramework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyApplication.Bindings.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage page;
        public LoginSteps()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            page = new LoginPage(driver);
        }


        [Given(@"I Navigate to the Login page")]
        public void GivenINavigateToTheLoginPage()
        {
            page.GoTo();
            
        }



        
        [When(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void WhenILoginWithUsernameAndPasswordOnTheLoginPage(string username, string password)
        {
            page.Login(username, password);
        }

        [Then(@"the url should contain '(.*)'")]
        public void ThenTheUrlShouldBe(string url)
        {
            Assert.IsTrue(page.GetUrl().Contains(url));
        }

    }
}
