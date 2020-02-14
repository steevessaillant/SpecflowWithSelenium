using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutomationFramework
{
    public class LoginPage : NavigatablePage
    {
        public IWebDriver driver;
        public override string GetUrl() => this.driver.Url;

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UsernameInput { get; set; }
      
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement SubmitButton { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            this.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        public void Login(string email, string password)
        {
            UsernameInput.SendKeys(email);
            PasswordInput.SendKeys(password);
            SubmitButton.Submit();
        }
       
    }
}
