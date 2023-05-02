using EaFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    public class LoginPage
    {
        private readonly IDriverFixture _driverFixture;
        public LoginPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }
        private IWebElement inputEmail => _driverFixture.Driver.FindElement(By.Id("exampleInputEmail"));
        private IWebElement inputPassword => _driverFixture.Driver.FindElement(By.Id("exampleInputPassword"));
        private IWebElement btnLogin => _driverFixture.Driver.FindElement(By.Id("btnLogin"));

        public void Login(string Email, string Password)
        {
            inputEmail.SendKeys(Email);
            inputPassword.SendKeys(Password);
            btnLogin.Click();
        }
    }
}