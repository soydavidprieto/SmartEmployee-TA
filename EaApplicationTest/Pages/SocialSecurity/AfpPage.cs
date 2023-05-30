using EaApplicationTest.Models;
using EaFramework.Driver;
using EaFramework.Extensions;

namespace EaApplicationTest.Pages.SocialSecurity
{
    public interface IAfpPage
    {
        void ClickAfp();
        void ClickCreate();
        void CreateAfp(Afp afp);
        void PerformClickOnSpecialValue(string name, string operation);
    }

    public class AfpPage : IAfpPage
    {
        private readonly IDriverWait _driver;
        public AfpPage(IDriverWait driver)
        {
            _driver = driver;
        }
        private IWebElement lnkAfp => _driver.FindElement(By.XPath("/html/body/div[1]/ul/li[2]/div/div/a[1]"));
        private IWebElement lnkCreateAfp => _driver.FindElement(By.Id("lnkCreateAfp"));
        private IWebElement inputNameAfp => _driver.FindElement(By.Id("inputNameAfp"));
        private IWebElement inputNitAfp => _driver.FindElement(By.Id("inputNitAfp"));
        private IWebElement bntCreate => _driver.FindElement(By.Id("bntCreate"));
        private IWebElement tbAfp => _driver.FindElement(By.Id("afpTable"));

        public void ClickAfp() => lnkAfp.Click();
        public void ClickCreate() => lnkCreateAfp.Click();

        public void CreateAfp(Afp afp)
        {
            inputNameAfp.SendKeys(afp.afpName);
            inputNitAfp.SendKeys(afp.afpNit);
            bntCreate.Click();

        }

        public void PerformClickOnSpecialValue(string name, string operation)
        {
            tbAfp.PerformActionOnCell("3", "Name", name, operation);
        }
    }
}
