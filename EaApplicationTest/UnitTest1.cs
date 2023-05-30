using AutoFixture.Xunit2;
using EaApplicationTest.Models;
namespace EaApplicationTest
{
    public class UnitTest1 : Global, IDisposable
    {
        private readonly IDriverFixture _driverFixture;
        private readonly IDriverWait _driverWait;
        private readonly ILoginPage _loginPage;
        private readonly IHomePage _homePage;
        private readonly IAfpPage _afpPage;

        public UnitTest1(IDriverFixture driverFixture,
                         ILoginPage loginPage,
                         IHomePage homePage,
                         IAfpPage afpPage)
        {
            _driverFixture = driverFixture;
            _loginPage = loginPage;
            _homePage = homePage;
            _afpPage = afpPage;
        }

        [Theory]
        [AutoData]
        public void Test1(Afp afp)
        {

            _loginPage.Login(emailAdmin, passwordAdmin);
            _homePage.clickSocialSecurity();
            _afpPage.ClickAfp();
            _afpPage.ClickCreate();
            _afpPage.CreateAfp(afp);
        }

        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}