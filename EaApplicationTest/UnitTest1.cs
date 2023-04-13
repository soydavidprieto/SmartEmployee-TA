using EaFramework.Config;
using EaFramework.Driver;
using OpenQA.Selenium;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                ApplicationUrl = new Uri("https://localhost:44322/"),
                TimeOutInverval = 30
            };

            var driver = new DriverFixture(testSettings);

            driver.Driver.FindElement(By.Id("exampleInputEmail")).SendKeys("soydavidprieto@gmail.com");
            driver.Driver.FindElement(By.Id("exampleInputPassword")).SendKeys("123456");
            driver.Driver.FindElement(By.Id("btnLogin")).Click();

        }
    }
}