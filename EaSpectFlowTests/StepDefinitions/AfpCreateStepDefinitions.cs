
using EaSpectFlowTests.Pages;
using EaSpectFlowTests.Pages.SocialSecurity;
using EaSpectFlowTests.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EaSpectFlowTests.StepDefinitions
{
    [Binding]
    public class AfpCreateStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ILoginPage _loginPage;
        private readonly IHomePage _homePage;
        private readonly IAfpPage _afpPage;

        public AfpCreateStepDefinitions(ScenarioContext scenarioContext,
                                        ILoginPage loginPage,
                                        IHomePage homePage,
                                        IAfpPage afpPage)
        {
            _scenarioContext = scenarioContext;
            _loginPage = loginPage;
            _homePage = homePage;
            _afpPage = afpPage;
        }

        [Given(@"I Login with the following details")]
        public void GivenILoginWithTheFollowingDetails(Table table)
        {
            _loginPage.Login("soydavidprieto@gmail.com", "123456");
        }

        [Given(@"I click on ""([^""]*)"" link")]
        public void GivenIClickOnLink(string lnkSocialSecurity)
        {
            _homePage.clickSocialSecurity();
        }

        [When(@"I click on apf ""([^""]*)"" link")]
        public void WhenIClickOnApfLink(string lnkAfp)
        {
            _afpPage.ClickAfp();
        }

        [Then(@"I create the Afp with the following details")]
        public void ThenICreateTheAfpWithTheFollowingDetails(Table table)
        {
            _afpPage.ClickCreate();
            var afp = table.CreateInstance<Afp>();
            _afpPage.CreateAfp(afp);
            _scenarioContext.Set<Afp>(afp);
         }
    }
}
