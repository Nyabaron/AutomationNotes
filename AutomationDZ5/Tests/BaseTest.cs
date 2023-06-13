using AutomationDZ5.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace AutomationDZ5.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected PageList Pages { get; private set; }

        protected ExtentReports extentReports;
        protected ExtentTest extentTests;

        [OneTimeSetUp]
        public void SetupReporting()
        {
            extentReports = new ExtentReports();
            string reportPath = "C:\\Users\\JOY&PASSION\\Documents\\Visual Studio 2022\\AutomationDZ\\MyReport.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extentReports.AttachReporter(htmlReporter);
        }
        [SetUp]
        public void Setup()
        {
            Driver = DriverHelper.GetDriver();
            Pages = new PageList(Driver);
            extentTests = extentReports.CreateTest(TestContext.CurrentContext.Test.FullName);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                extentTests.Log(Status.Pass);
            }
            else
            {
                var path = DriverHelper.MakeScreenshot(Driver, TestContext.CurrentContext.Test.MethodName);
                extentTests.AddScreenCaptureFromPath(path);
                extentTests.Log(Status.Fail);
            }
            Driver.Quit();
        }

        [OneTimeTearDown]
        public void FlushReports()
        {
            extentReports.Flush();
        }
    }
}
