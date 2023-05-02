using EaApplicationTest.Models;
using EaFramework.Driver;
using EaFramework.Extensions;

namespace EaApplicationTest.Pages.SocialSecurity
{
    public class AfpPage
    {
        private readonly IDriverFixture _driverFixture;
        public AfpPage (IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }
        private IWebElement lnkAfp => _driverFixture.Driver.FindElement(By.XPath("/html/body/div[1]/ul/li[2]/div/div/a[1]"));
        private IWebElement lnkCreateAfp => _driverFixture.Driver.FindElement(By.Id("lnkCreateAfp"));
        private IWebElement inputNameAfp => _driverFixture.Driver.FindElement(By.Id("inputNameAfp"));
        private IWebElement inputNitAfp => _driverFixture.Driver.FindElement(By.Id("inputNitAfp"));
        private IWebElement bntCreate => _driverFixture.Driver.FindElement(By.Id("bntCreate"));
        private IWebElement tbAfp => _driverFixture.Driver.FindElement(By.Id("afpTable"));

        public void ClickAft() => lnkAfp.Click();
        public void ClickCreate() => lnkCreateAfp.Click();

    public void CreateAfp(string Name, string Nit)
        {
            inputNameAfp.SendKeys(Name);
            inputNitAfp.SendKeys(Nit);
            bntCreate.Click();

        }

        public void PerformClickOnSpecialValue(string name, string operation)
        {
            tbAfp.PerformActionOnCell("3", "Name", name, operation);
        }
    }
}
