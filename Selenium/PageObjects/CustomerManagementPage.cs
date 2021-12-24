using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    public class CustomerManagementPage
    {
        IWebDriver driver;
        public CustomerManagementPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement addCustomerButton => driver.FindElement(By.ClassName("btn btn-success"));
        public IWebElement specificCustomerCheckbox => driver.FindElement(By.XPath("//td[text()='Ankit']//preceding-sibling::td//input"));
        public IWebElement deleteCustomerButton => driver.FindElement(By.Id("deleteAll"));

    }
}
