using EaSpectFlowTests.Models;
using EaFramework.Driver;
using EaFramework.Extensions;
using System.Diagnostics;
using OpenQA.Selenium;

namespace EaSpectFlowTests.Pages.SocialSecurity
{
    public interface IAfpPage
    {
        void ClickAfp();
        void ClickCreate();
        void CreateAfp(Afp afp);
        void CreateAfpManual(string Name, string Nit);
        string GetAfpName();
        void PerformClickOnSpecialValue(string name, string operation);
    }

    public class AfpPage : IAfpPage
    {
        private readonly IDriverWait _driver;
        public AfpPage(IDriverWait driver)
        {
            _driver = driver;
        }
        private IWebElement lnkAfp => _driver.FindElement(By.LinkText("AFP"));
        private IWebElement lnkCreateAfp => _driver.FindElement(By.Id("lnkCreateAfp"));
        private IWebElement afpName => _driver.FindElement(By.Id("inputNameAfp"));
        private IWebElement inputNitAfp => _driver.FindElement(By.Id("inputNitAfp"));
        private IWebElement bntCreate => _driver.FindElement(By.Id("bntCreate"));
        private IWebElement tblList => _driver.FindElement(By.Id("afpTable"));

        public void ClickAfp() => lnkAfp.Click();
        public void ClickCreate() => lnkCreateAfp.Click();

        public void CreateAfp(Afp afp)
        {
            afpName.SendKeys(afp.afpName);
            inputNitAfp.SendKeys(afp.afpNit);
            bntCreate.Click();

        }

        public void CreateAfpManual(string Name, string Nit)
        {
            afpName.SendKeys(Name);
            inputNitAfp.SendKeys(Nit);
            bntCreate.Click();

        }

        public void PerformClickOnSpecialValue(string name, string operation)
        {
            tblList.PerformActionOnCell("3", "Name", name, operation);
        }

        public string GetAfpName() => afpName.Text;
    }
}
