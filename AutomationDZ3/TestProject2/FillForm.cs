using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutoFillForm
{
    public class FillForm
    {
        IWebDriver Driver { get; set; }

        private void ClickElem(string xpath)
        {
            var element = Driver.FindElement(By.XPath(xpath));
            element.Click();
        }
        private void SendKeysToElem(string id, string key)
        {
            var element = Driver.FindElement(By.Id(id));
            element.SendKeys(key);
        }

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void Test1()
        {
            string forms = "//div[contains(@class, 'category-cards')]/div[2]";
            ClickElem(forms);

            string practiceForm = "//*[contains(text(), 'Practice Form')]/..";
            ClickElem(practiceForm);

            SendKeysToElem("firstName", "RandomName");

            SendKeysToElem("lastName", "RandomLastName");

            SendKeysToElem("userEmail", "random@email.com");

            string gender = "//*[@id='genterWrapper']/div[2]/div[3]";
            ClickElem(gender);

            SendKeysToElem("userNumber", "1234567890");

            string date = "//*[@id='dateOfBirthInput']";
            ClickElem(date);

            var year = Driver.FindElement(By.XPath("//*[contains(@class, 'year-select')]"));
            var selectYear = new SelectElement(year);
            selectYear.SelectByValue("2000");

            var month = Driver.FindElement(By.XPath("//*[contains(@class, 'month-select')]"));
            var selectMonth = new SelectElement(month);
            selectMonth.SelectByValue("10");

            string day = "//*[contains(@aria-label , '20th')]";
            ClickElem(day);

            SendKeysToElem("subjectsInput", "Hindi");
            SendKeysToElem("subjectsInput", Keys.Enter);

            string hobby1 = "//*[@id='hobbiesWrapper']/div[2]/div[1]";
            string hobby2 = "//*[@id='hobbiesWrapper']/div[2]/div[2]";
            string hobby3 = "//*[@id='hobbiesWrapper']/div[2]/div[3]";
            ClickElem(hobby1);
            ClickElem(hobby2);
            ClickElem(hobby3);

            SendKeysToElem("uploadPicture", "C:\\Users\\JOY&PASSION\\Pictures\\42502.jpg");

            SendKeysToElem("currentAddress", "Random Address");

            SendKeysToElem("react-select-3-input", "Uttar");
            SendKeysToElem("react-select-3-input", Keys.Enter);

            SendKeysToElem("react-select-4-input", "Merrut");
            SendKeysToElem("react-select-4-input", Keys.Enter);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}