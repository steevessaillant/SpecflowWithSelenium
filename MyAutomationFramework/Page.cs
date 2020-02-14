using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyAutomationFramework
{
    public abstract class Page
    {
        protected Page(IWebDriver driver)
        {
            WrappedDriver = driver;
            PageFactory.InitElements(driver, this);
        }
        protected IWebDriver WrappedDriver { get; }


    }
}
