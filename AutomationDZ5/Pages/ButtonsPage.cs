using AutomationDZ5.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationDZ5
{
    public class ButtonsPage : BasePage
    {
        private IWebElement _doubleClickMsg;
        private IWebElement _rightClickMsg;
        private IWebElement _clickMeMsg;
        private IWebElement _doubleClick => driver.FindElement(By.Id("doubleClickBtn"));
        private IWebElement _rightClick => driver.FindElement(By.Id("rightClickBtn"));
        private IWebElement _clickMe => driver.FindElement(By.XPath("//*[text() = 'Click Me']"));
        protected override string url => "http://demoqa.com/buttons";

        public ButtonsPage(IWebDriver driver) : base(driver)
        {
        }

        public void DoubleClick()
        {
            Actions act = new Actions(driver);
            act.DoubleClick(_doubleClick).Perform();
        }
        public void RightClick()
        {
            Actions act = new Actions(driver);
            act.ContextClick(_rightClick).Perform();
        }
        public void ClickMe()
        {
            Actions act = new Actions(driver);
            act.Click(_clickMe).Perform();
        }

        public string GetDoubleClickMsg()
        {
            _doubleClickMsg = driver.FindElement(By.Id("doubleClickMessage"));
            string msg = _doubleClickMsg.Text;
            return msg;
        }
        public string GetRightClickMsg()
        {
            _rightClickMsg = driver.FindElement(By.Id("rightClickMessage"));
            string msg = _rightClickMsg.Text;
            return msg;
        }
        public string GetClickMeMsg()
        {
            _clickMeMsg = driver.FindElement(By.Id("dynamicClickMessage"));
            string msg = _clickMeMsg.Text;
            return msg;
        }
    }
}
