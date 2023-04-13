using EaFramework.Config;
using EaFramework.Driver;
using OpenQA.Selenium;

namespace EaApplicationTest
{
    public class UnitTest1 : IDisposable
    {
        private readonly IDriverFixture _driverFixture;
        public UnitTest1()
        {
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                ApplicationUrl = new Uri("https://localhost:44322/"),
                TimeOutInverval = 30
            };

            _driverFixture = new DriverFixture(testSettings);
        }

        [Fact]
        public void Test1()
        {
            _driverFixture.Driver.FindElement(By.Id("exampleInputEmail")).SendKeys("soydavidprieto@gmail.com");
            _driverFixture.Driver.FindElement(By.Id("exampleInputPassword")).SendKeys("123456");
            _driverFixture.Driver.FindElement(By.Id("btnLogin")).Click();
        }
        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}