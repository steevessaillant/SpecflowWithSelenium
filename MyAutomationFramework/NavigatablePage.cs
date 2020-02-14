using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutomationFramework
{
    public abstract class NavigatablePage : Page
    {
        protected NavigatablePage(IWebDriver driver) : base(driver)
        {
        }

        public abstract string GetUrl();
        public void GoTo() => WrappedDriver.Navigate().GoToUrl(GetUrl());
        public void Refresh() => WrappedDriver.Navigate().Refresh();
    }
}
