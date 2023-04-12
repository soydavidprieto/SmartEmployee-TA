using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFramework.Driver
{
    public class DriverFixture
    {
        public IWebDriver Driver { get; }

        public DriverFixture(BrowserType browserType)
        {
            Driver = GetWebDriver(browserType);
            Driver.Navigate().GoToUrl("https://localhost:44322/");
        }

        private IWebDriver GetWebDriver(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Safari => new SafariDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                _ => new ChromeDriver()

            } ;
             
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
