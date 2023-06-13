
using OpenQA.Selenium;

namespace AutomationDZ5.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;
        protected abstract string url { get; }


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
