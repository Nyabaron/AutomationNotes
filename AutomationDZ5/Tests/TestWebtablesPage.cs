namespace AutomationDZ5.Tests
{
    internal class TestWebtablesPage : BaseTest
    {

        [SetUp]
        public new void Setup()
        {
            Pages.Webtables.Open();
        }

        [Test, Order(1)]
        public void TestAddEmployee()
        {
            Pages.Webtables.AddEmployee("test", "test", "test@test.com", "20", "1500", "test");
            string employee = Pages.Webtables.GetEmployee(3);
            Assert.True(employee.StartsWith("test"));
        }

        [Test, Order(2)]
        public void TestEditEmployee()
        {
            Pages.Webtables.EditEmployee("2", "test2", "test2", "test2@test.com", "22", "1502", "test2");
            string employee = Pages.Webtables.GetEmployee(1);
            Assert.True(employee.StartsWith("test2"));
        }

        [Test, Order(3)]
        public void TestSearchEmployee()
        {
            Pages.Webtables.SearchEmployee("Kierra");
            string employee = Pages.Webtables.GetEmployee(0);
            Assert.True(employee.StartsWith("Kierra"));
        }

        [Test, Order(4)]
        public void TestRowsDisplay()
        {
            Pages.Webtables.RowsDisplayed("20");
            Assert.True(Pages.Webtables.GetAllEmployees().Count == 20);
        }

        [Test, Order(5)]
        public void TestDeleteEmployee()
        {
            Pages.Webtables.DeleteEmployee("3");
            string employee = Pages.Webtables.GetEmployee(2);
            Assert.That(employee, Is.Not.StartsWith("Kierra"));
        }

    }
}

