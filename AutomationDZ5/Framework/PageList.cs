using OpenQA.Selenium;

namespace AutomationDZ5.Framework
{
    public class PageList
    {
        private readonly IWebDriver _driver;
        public PageList(IWebDriver driver)
        {
            _driver = driver;
        }
        public WebtablesPage Webtables => _webtables ??= new WebtablesPage(_driver);
        private WebtablesPage _webtables;

        public ButtonsPage Buttons => _buttons ??= new ButtonsPage(_driver);
        private ButtonsPage _buttons;

    }
}
