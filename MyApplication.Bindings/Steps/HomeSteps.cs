using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAutomationFramework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyAutomation.Bindings.Steps
{
    [Binding, Scope(Feature = "Create an Home Page and its structure as my sample react-redux application")]
    public class HomeSteps : SharedSteps
    {
        const string DEFAULT_URL = @"http://localhost:3000/";

        public HomePage Page { get; set; }

        public string Url { get; set;}

        public HomeSteps() 
        {
            this.Url = DEFAULT_URL;
            this.Page = new HomePage(ScenarioContext.Current.Get<IWebDriver>("currentDriver"));
            base.Page = Page;
            this.Page.GoTo(DEFAULT_URL);
        }

        [Given(@"I am at the root of the site")]
        public void GivenIAmAtTheRootOfTheSite()
        {
            Assert.AreEqual(this.Page.GetUrl(), this.Url);
        }
        
        [Given(@"I am at the Home Page")]
        public void GivenIAmAtTheHomePage()
        {
            Assert.AreEqual(this.Page.GetUrl(), DEFAULT_URL);

        }

        [When(@"I press the Login button")]
        public void WhenIPressTheLoginButton()
        {
            this.Page.LoginButton.Click();
        }


        [When(@"I type '(.*)' after the url displayed in the url field in my browser")]
        public void WhenITypeAfterTheUrlDisplayedInTheUrlFieldInMyBrowser(string resource)
        {
            this.Page.GoTo(resource);
        }
        

        [Then(@"I should see the Home Page")]
        public void ThenIShouldSeeTheHomePage()
        {
            Assert.AreEqual(this.Url, this.Page.GetUrl());
        }
    }
}
