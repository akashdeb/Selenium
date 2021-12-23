using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    internal class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement usernameTextField => driver.FindElement(By.Name("email"));
        public IWebElement passwordTextField => driver.FindElement(By.Name("password"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//span[text()='Login']"));
        public IWebElement invalidError => driver.FindElement(By.XPath("//div[text()='Invalid Login Credentials']"));


    }
}
    
