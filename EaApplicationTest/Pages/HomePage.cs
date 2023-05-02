namespace EaApplicationTest.Pages
{
    public class HomePage
    {
        private readonly IDriverFixture _driverFixture;

        public  HomePage (IDriverFixture driverFixture)
    {
            _driverFixture = driverFixture;
    }

        private IWebElement lnkHome => _driverFixture.Driver.FindElement(By.Id("lnkHome"));
        private IWebElement lnkEmployee => _driverFixture.Driver.FindElement(By.Id("lnkEmployee"));
        private IWebElement lnkSocialSecurity => _driverFixture.Driver.FindElement(By.Id("lnkSocialSecurity"));
        private IWebElement lnkAdministration => _driverFixture.Driver.FindElement(By.Id("lnkAdministration"));

        public void clickEmployee() => lnkEmployee.Click(); 
        public void clickSocialSecurity () => lnkSocialSecurity.Click();

}
}
