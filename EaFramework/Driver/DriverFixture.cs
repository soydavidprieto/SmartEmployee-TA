using EaFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace EaFramework.Driver
{
    public class DriverFixture
    {
        private readonly TestSettings testSettings;
        private TestSettings _testSettings;

        public IWebDriver Driver { get; }

        public DriverFixture(TestSettings testSettings)
        {
            _testSettings = testSettings;
            Driver = GetWebDriver();
            Driver.Navigate().GoToUrl(_testSettings.ApplicationUrl);
        }

        private IWebDriver GetWebDriver()
        {
            return _testSettings.BrowserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Safari => new SafariDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                _ => new ChromeDriver()

            };
        }
    }

    public enum BrowserType
    {
        Chrome,
        Safari,
        Firefox,
        EdgeChromiun
    }
}
