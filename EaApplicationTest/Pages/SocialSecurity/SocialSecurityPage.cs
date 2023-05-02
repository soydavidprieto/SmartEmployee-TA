namespace EaApplicationTest.Pages.SocialSecurity
{
    public class SocialSecurityPage
    {
        private readonly IDriverFixture _driverFixture;
        public SocialSecurityPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement lnkAfp => _driverFixture.Driver.FindElement(By.Id("lnkAfp"));
        private IWebElement lnkArl => _driverFixture.Driver.FindElement(By.Id("lnkArl"));
        private IWebElement lnkEps => _driverFixture.Driver.FindElement(By.Id("lnkEps"));
        private IWebElement lnkCcf  => _driverFixture.Driver.FindElement(By.Id("lnkCcf"));
    }
}
