using AutoFixture.Xunit2;
using EaApplicationTest.Models;
namespace EaApplicationTest
{
    public class UnitTest1 : Global, IDisposable
    {
        private readonly IDriverFixture _driverFixture;
        private IDriverWait _driverWait;
        public UnitTest1()
        {
            //var testSettings = new TestSettings()
            //{
            //    BrowserType = BrowserType.Chrome,
            //    ApplicationUrl = new Uri("https://localhost:44322/"),
            //    TimeOutInverval = 30
            //};

            var testSettings = ConfigReader.ReadConfig();

            _driverFixture = new DriverFixture(testSettings);
            _driverWait = new DriverWait(_driverFixture, testSettings);

        }

        //[Fact]
        //[InlineData("Skandia", "3453456-1")]
        //[InlineData("Segurps Alfa", "7895934-1")]
        //[InlineData("Seguros Falabbela", "3845973")]
        [Theory]
        [AutoData]
        public void Test1(Afp afp)
        {
            var loginPage = new LoginPage(_driverWait);
            var homePage = new HomePage(_driverWait);
            var afpPage = new AfpPage(_driverWait);

            //Afp afp = new Afp()
            //{
            //    afpName = "Afp1",
            //    afpNit = "94785-1"
            //};

            loginPage.Login(emailAdmin, passwordAdmin);
            homePage.clickSocialSecurity();
            afpPage.ClickAft();
            afpPage.ClickCreate();
            afpPage.CreateAfp(afp);
            //afpPage.PerformClickOnSpecialValue(afp.afpName, "Edit");
        }

        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}