using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDZ5.Framework
{
    internal class DriverHelper
    {
        public static IWebDriver GetDriver()
        {
            var driver = new ChromeDriver();
            return driver;
        }

        internal static string MakeScreenshot(IWebDriver driver, string testName)
        {
            string screenshotfolder = "C:\\Users\\JOY&PASSION\\Documents\\Visual Studio 2022\\AutomationDZ";
            string screenshotPath = string.Empty;

            if (driver != null)
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

                var dateTimeStr = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
                var screenshotName = $"{testName}-{dateTimeStr}";

                screenshotPath = Path.Combine(screenshotfolder, screenshotName);
                screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
            }

            return screenshotPath;
        }
    }
}
