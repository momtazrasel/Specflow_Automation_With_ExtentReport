using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Automation_PartOne.Pages
{
    public class LoginObject
    {
        private IWebDriver driver;

        public LoginObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        By MyAccountButton = By.XPath("(//span[normalize-space()='My Account'])[1]");
        By LoginOption = By.XPath("(//a[normalize-space()='Login'])[1]");
        By EmailTextField = By.XPath("(//input[@id='input-email'])[1]");
        By PasswordTextField = By.XPath("(//input[@id='input-password'])[1]");
        By LoginButton = By.XPath("(//input[@value='Login'])[1]");
        By AlertText = By.XPath("(//div[@class='alert alert-danger alert-dismissible'])[1]");
        By AdvanceButton = By.XPath("//button[@class = 'secondary-button small-link']");
        By proceedLink = By.XPath("//a[@id= 'proceed-link']");


        public void myAccount()
        {
            driver.FindElement(AdvanceButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(proceedLink).Click();
            Thread.Sleep(1000);
            driver.FindElement(MyAccountButton).Click();
            Thread.Sleep(1000);
        }
        public void getLoginOption()
        {
            driver.FindElement(LoginOption).Click();
            Thread.Sleep(1000);
        }
        public void getEmailTextField()
        {
            driver.FindElement(EmailTextField).SendKeys("devidmore@gmail.com");
            Thread.Sleep(1000);
        }
        public void getInvalidEmail()
        {
            driver.FindElement(EmailTextField).SendKeys("xyz@gmail");
            Thread.Sleep(1000);
        }
        public void getPasswordTextField()
        {
            driver.FindElement(PasswordTextField).SendKeys("Test");
            Thread.Sleep(1000);
        }
        public void getValidPassword()
        {
            driver.FindElement(PasswordTextField).SendKeys("123456");
            Thread.Sleep(1000);
        }
        public void getLoginButton()
        {
            driver.FindElement(LoginButton).Click();
            Thread.Sleep(1000);
        }
        public void alertText()
        {
           //String actualText = driver.FindElement(AlertText).Text;
           // Assert.AreEqual(actualText, AlertText, "Warning: No match for E-Mail Address and/or Password.");

        }
    }
}
