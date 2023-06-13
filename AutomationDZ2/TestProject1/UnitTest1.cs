using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver Driver { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test, Order(1)]
        public void FindActiveCards()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            var cards = Driver.FindElements(By.XPath("//div[@class='category-cards']/div"));
        }
        [Test, Order(2)]
        public void PracticeFormBtn()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/forms");
            var btn = Driver.FindElement(By.XPath("//*[contains(text(), 'Practice Form')]/.."));
        }
        [Test, Order(3)]
        public void MainItem3()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/menu");
            var cards = Driver.FindElement(By.XPath("//a[contains(text(), 'Main Item 3')]"));
        }
        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
