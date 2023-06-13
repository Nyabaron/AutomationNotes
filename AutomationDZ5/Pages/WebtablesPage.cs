using AutomationDZ5.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationDZ5
{
    public class WebtablesPage : BasePage
    {

        private IWebElement addBtn => driver.FindElement(By.Id("addNewRecordButton"));
        private IWebElement searchInput => driver.FindElement(By.Id("searchBox"));
        private IWebElement editBtn;
        private IWebElement deleteBtn;
        private IWebElement nameInput => driver.FindElement(By.Id("firstName"));
        private IWebElement lastNameInput => driver.FindElement(By.Id("lastName"));
        private IWebElement emailInput => driver.FindElement(By.Id("userEmail"));
        private IWebElement ageInput => driver.FindElement(By.Id("age"));
        private IWebElement salaryInput => driver.FindElement(By.Id("salary"));
        private IWebElement departmentInput => driver.FindElement(By.Id("department"));
        private IWebElement sbmtBtn => driver.FindElement(By.Id("submit"));
        private List<IWebElement> employees => driver.FindElements(By.XPath("//*[contains(@class, 'rt-tr-group')]")).ToList();

        protected override string url => "http://demoqa.com/webtables";

        public WebtablesPage(IWebDriver driver) : base(driver)
        {
        }

        public void AddEmployee(string name, string lastName, string email, string age, string salary, string department)
        {
            addBtn.Click();
            nameInput.SendKeys(name);
            lastNameInput.SendKeys(lastName);
            emailInput.SendKeys(email);
            ageInput.SendKeys(age);
            salaryInput.SendKeys(salary);
            departmentInput.SendKeys(department);
            sbmtBtn.Click();
        }
        public string GetEmployee(int index)
        {
            string selectedEmployee = employees[index].Text;
            return selectedEmployee;
        }
        public List<IWebElement> GetAllEmployees()
        {
            List<IWebElement> selectedEmployee = employees;
            return selectedEmployee;
        }
        public void EditEmployee(string index, string name, string lastName, string email, string age, string salary, string department)
        {
            editBtn = driver.FindElement(By.Id("edit-record-" + index));
            editBtn.Click();
            nameInput.Clear();
            nameInput.SendKeys(name);
            lastNameInput.Clear();
            lastNameInput.SendKeys(lastName);
            emailInput.Clear();
            emailInput.SendKeys(email);
            ageInput.Clear();
            ageInput.SendKeys(age);
            salaryInput.Clear();
            salaryInput.SendKeys(salary);
            departmentInput.Clear();
            departmentInput.SendKeys(department);
            sbmtBtn.Click();
        }
        public void DeleteEmployee(string index)
        {
            deleteBtn = driver.FindElement(By.Id("delete-record-" + index));
            deleteBtn.Click();
        }
        public void SearchEmployee(string search)
        {
            searchInput.SendKeys(search);
            searchInput.SendKeys(Keys.Enter);
        }
        public void RowsDisplayed(string rows)
        {
            var element = driver.FindElement(By.XPath("//select[contains(@aria-label, 'rows')]"));
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(rows);
        }
    }
}
