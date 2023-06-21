using EaSpectFlowTests.Models;
using EaSpectFlowTests.Pages;
using EaSpectFlowTests.Pages.SocialSecurity;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using FluentAssertions;

namespace EaSpectFlowTests.StepDefinitions
{

    [Binding]
    public class AfpAssertionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ILoginPage _loginPage;
        private readonly IHomePage _homePage;
        private readonly IAfpPage _afpPage;

        public AfpAssertionStepDefinitions(ScenarioContext scenarioContext,
                                        ILoginPage loginPage,
                                        IHomePage homePage,
                                        IAfpPage afpPage)
        {
            _scenarioContext = scenarioContext;
            _loginPage = loginPage;
            _homePage = homePage;
            _afpPage = afpPage;
        }

        [Given(@"I Login with admin user")]
        public void GivenILoginWithAdminUser(Table table)
        {
            _loginPage.Login("soydavidprieto@gmail.com", "123456");
        }

        [Given(@"I go to ""([^""]*)"" link")]
        public void GivenIGoToLink(string lnkSocialSecurity)
        {
            _homePage.clickSocialSecurity();
        }

        [Given(@"I click on apf ""([^""]*)"" link")]
        public void GivenIClickOnApfLink(string lnkAfp)
        {
            _afpPage.ClickAfp();
        }

        [When(@"I create the Afp with the following details")]
        public void WhenICreateTheAfpWithTheFollowingDetails(Table table)
        {
            _afpPage.ClickCreate();
            var afp = table.CreateInstance<Afp>();
            _afpPage.CreateAfp(afp);
            _scenarioContext.Set<Afp>(afp);
        }

        [Then(@"I see all the AFP details are created as expected")]
        public void ThenISeeAllTheAFPDetailsAreCreatedAsExpected()
        {
            var afp = _scenarioContext.Get<Afp>();
            _afpPage.GetAfpName().Should().BeEquivalentTo(afp.afpName.Trim());
        }
    }
}
