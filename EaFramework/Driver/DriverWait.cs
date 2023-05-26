using EaFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFramework.Driver
{
    public class DriverWait : IDriverWait
    {
        private readonly IDriverFixture _driverFixture;
        private readonly TestSettings _testSettings;
        private readonly Lazy<WebDriverWait> _webDriverWait;

        public DriverWait(IDriverFixture driverFixture, TestSettings testSettings)
        {
            _driverFixture = driverFixture;
            _testSettings = testSettings;
            _webDriverWait = new Lazy<WebDriverWait>(GetWaitDriver);

        }

        public IWebElement FindElement(By elementLocator)
        {
            return _webDriverWait.Value.Until(_ => _driverFixture.Driver.FindElement(elementLocator));
        }

        public IEnumerable<IWebElement> FindElements(By elementLocator)
        {
            throw new NotImplementedException();
        }

        public IWebElement FinElement(By elementLocator)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWebElement> FinElements(By elementLocator)
        {
            return _webDriverWait.Value.Until(_ => _driverFixture.Driver.FindElements(elementLocator));
        }

        private WebDriverWait GetWaitDriver()
        {
            return new(_driverFixture.Driver, timeout: TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 30))
            {
                PollingInterval = TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 1)
            };
        }
    }
}
