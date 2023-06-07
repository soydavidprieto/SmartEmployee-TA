using AutoFixture.Xunit2;
using EaApplicationTest.Models;
namespace EaApplicationTest
{
    public class UnitTest1 : Global
    {
        
        private readonly IDriverWait _driverWait;
        private readonly ILoginPage _loginPage;
        private readonly IHomePage _homePage;
        private readonly IAfpPage _afpPage;

        public UnitTest1(ILoginPage loginPage,
                         IHomePage homePage,
                         IAfpPage afpPage)
        {
            
            _loginPage = loginPage;
            _homePage = homePage;
            _afpPage = afpPage;
        }

        [Theory]
        [AutoData]
        public void Create_afp_test(Afp afp)
        {

            _loginPage.Login(emailAdmin, passwordAdmin);
            _homePage.clickSocialSecurity();
            _afpPage.ClickAfp();
            _afpPage.ClickCreate();
            _afpPage.CreateAfp(afp);
        }

       
    }
}