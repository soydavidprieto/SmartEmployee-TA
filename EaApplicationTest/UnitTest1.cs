using AutoFixture.Xunit2;
using EaApplicationTest.Models;
namespace EaApplicationTest
{
    public class UnitTest1 : Global, IDisposable
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
            var loginPage = new LoginPage(_driverFixture);
            var homePage = new HomePage(_driverFixture);
            var afpPage = new AfpPage(_driverFixture);

            loginPage.Login(emailAdmin, passwordAdmin);
            homePage.clickSocialSecurity();
            afpPage.ClickAft();
           // afpPage.ClickCreate();
            //afpPage.CreateAfp("Colmedica", "187346136-0");
            afpPage.PerformClickOnSpecialValue("Colmedica", "Edit");
        }

        public void Dispose()
        {
            //_driverFixture.Driver.Quit();
        }
    }
}