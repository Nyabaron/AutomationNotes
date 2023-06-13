namespace AutomationDZ5.Tests
{
    public class TestButtonsPage : BaseTest
    {
        [SetUp]
        public new void Setup()
        {
            Pages.Buttons.Open();
        }

        [Test]
        public void TestDoubleBtn()
        {
            Pages.Buttons.DoubleClick();
            string doubleMsg = Pages.Buttons.GetDoubleClickMsg();
            Assert.True(doubleMsg == "You have done a double click");
        }
        [Test]
        public void TestRightBtn()
        {
            Pages.Buttons.RightClick();
            string rightMsg = Pages.Buttons.GetRightClickMsg();
            Assert.True(rightMsg == "You have done a right click");

        }
        [Test]
        public void TestMeBtn()
        {
            Pages.Buttons.ClickMe();
            string meMsg = Pages.Buttons.GetClickMeMsg();
            Assert.True(meMsg == "You have done a dynamic click");
        }


    }
}