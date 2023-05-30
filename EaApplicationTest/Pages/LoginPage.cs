using EaFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    public interface ILoginPage
    {
        void Login(string Email, string Password);
    }

    public class LoginPage : ILoginPage
    {
        private readonly IDriverWait _driver;
        public LoginPage(IDriverWait driver)
        {
            _driver = driver;
        }
        private IWebElement inputEmail => _driver.FindElement(By.Id("exampleInputEmail"));
        private IWebElement inputPassword => _driver.FindElement(By.Id("exampleInputPassword"));
        private IWebElement btnLogin => _driver.FindElement(By.Id("btnLogin"));

        public void Login(string Email, string Password)
        {
            inputEmail.SendKeys(Email);
            inputPassword.SendKeys(Password);
            btnLogin.Click();
        }
    }
}