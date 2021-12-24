using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.CustomMethods;
using Selenium.PageObjects;

namespace Selenium.Tests
{

    public class LoginTests
        {
           IWebDriver driver;
            [Test]
            public void VerifyValidLoginToApplication()
            {

            LoginPage login=new LoginPage(driver);
            login.usernameTextField.SendKeys("admin@phptravels.com");
            login.passwordTextField.SendKeys("demoadmin");
            login.loginButton.Click();

            }
            [Test]
            public void VerifyInValidLoginToApplication()
            {

            }
            [Test]
            public void VerifyLogOutToApplication()
            {

            }
        }
}
