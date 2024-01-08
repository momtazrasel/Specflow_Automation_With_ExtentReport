using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Automation_PartOne.Pages;

namespace Automation_PartOne.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        LoginObject loginPage;

       public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the URL")]
        public void GivenEnterTheURL()
        {
            driver.Url = "https://www.demoshop24.com/";
            Thread.Sleep(2000);
        }

        // New
        [When(@"Click on the My Account Button")]
        public void WhenClickOnTheMyAccountButton()
        {
            loginPage = new LoginObject(driver);
            Thread.Sleep(2000);
            loginPage.myAccount();
        }

        [When(@"Click on the Login Option")]
        public void WhenClickOnTheLoginOption()
        {
            loginPage.getLoginOption();
           
        }

        [When(@"User enter valid username and invalid password in login form")]
        public void WhenUserEnterValidUsernameAndInvalidPasswordInLoginForm()
        {
            Thread.Sleep(1000);
            loginPage.getEmailTextField();
            loginPage.getPasswordTextField();

        }

        [When(@"Clicks on Log in button")]
        public void WhenClicksOnLogInButton()
        {
            Thread.Sleep(1000);
            loginPage.getLoginButton();

        }

        [Then(@"Verify that the username or password is invalid")]
        public void ThenVerifyThatTheUsernameOrPasswordIsInvalid()
        {
            loginPage.alertText();
        }

        [When(@"User enter valid username and password in login form")]
        public void WhenUserEnterValidUsernameAndPasswordInLoginForm()
        {
            Thread.Sleep(1000);
            loginPage.getEmailTextField();
            loginPage.getValidPassword();
        }

        [When(@"User enter invalid username and valid password in login form")]
        public void WhenUserEnterInvalidUsernameAndValidPasswordInLoginForm()
        {
            Thread.Sleep(1000);
            loginPage.getInvalidEmail();
            loginPage.getValidPassword();
        }


    }
}