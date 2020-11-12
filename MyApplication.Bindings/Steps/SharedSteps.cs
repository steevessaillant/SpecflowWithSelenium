using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAutomationFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MyAutomation.Bindings.Steps
{
    public class SharedSteps
    {
        public IWebDriver Driver { get; set; }
        public NavigatablePage Page{ get; set;}

        public SharedSteps()
        {
            if (ScenarioContext.Current["currentDriver"] != null)
                this.Driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@"I have a browser")]
        public void GivenIHaveABrowser()
        {
            Assert.IsNotNull(this.Driver);
        }

        [Then(@"the page title should be '(.*)'")]
        public void ThenThePageTitleShouldBe(string title)
        {
            Assert.AreEqual(title, this.Page.Title);
        }


        [When(@"I enter '(.*)'")]
        public void WhenIEnter(string resource) => this.Page.GoTo(resource);
    }
}
