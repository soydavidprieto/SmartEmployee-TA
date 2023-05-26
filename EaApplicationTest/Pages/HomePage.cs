namespace EaApplicationTest.Pages
{
    public class HomePage
    {
        private readonly IDriverWait _driver;

        public  HomePage(IDriverWait driver)
        {
            _driver = driver;
        }

        private IWebElement lnkHome => _driver.FindElement(By.Id("lnkHome"));
        private IWebElement lnkEmployee => _driver.FindElement(By.Id("lnkEmployee"));
        private IWebElement lnkSocialSecurity => _driver.FindElement(By.Id("lnkSocialSecurity"));
        private IWebElement lnkAdministration => _driver.FindElement(By.Id("lnkAdministration"));

        public void clickEmployee() => lnkEmployee.Click(); 
        public void clickSocialSecurity () => lnkSocialSecurity.Click();

}
}
