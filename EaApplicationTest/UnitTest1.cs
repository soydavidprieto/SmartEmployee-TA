using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://localhost:44322/");

            driver.FindElement(By.Id("exampleInputEmail")).SendKeys("soydavidprieto@gmail.com");
            driver.FindElement(By.Id("exampleInputPassword")).SendKeys("123456");
            driver.FindElement(By.Id("btnLogin")).Click();

        }
    }
}