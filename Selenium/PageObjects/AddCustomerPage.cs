using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    public class AddCustomerPage
    {
        IWebDriver driver;
        public AddCustomerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public IWebElement firstNameTextfield => driver.FindElement(By.XPath("//input[@placeholder='First name']"));
        public IWebElement submitButton => driver.FindElement(By.ClassName("btn btn-primary btn-block btn-lg"));

    }
}
