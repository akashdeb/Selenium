using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    public class DashboardPage
    {
        IWebDriver driver;
       public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement bookingsButton => driver.FindElement(By.ClassName("btn btn - primary btn - block"));
        public IWebElement cmspageButton => driver.FindElement(By.ClassName("btn btn-info btn-block"));
        public IWebElement blogButton => driver.FindElement(By.ClassName("glyphicon glyphicon-th-large fa-lg"));
        public IWebElement newsletterButton => driver.FindElement(By.ClassName("fa fa-envelope fa-lg"));      
        public IWebElement backupButton => driver.FindElement(By.ClassName("fa fa-inbox fa-lg"));
        public IWebElement carLink => driver.FindElement(By.XPath("//a[@href='javascript:void(0);#carsmodule']"));
        public IWebElement hotelLink => driver.FindElement(By.XPath("//a[@href='javascript:void(0);#hotelsmodule']"));
        public IWebElement flightlLink => driver.FindElement(By.XPath("//a[@href='javascript:void(0);#flightsmodule']"));
        public IWebElement accountlLink => driver.FindElement(By.XPath("//small/ancestor::div[@class='container-fluid']/descendant::i[@class='fa fa-user-circle']"));
        public IWebElement CustomerOption => driver.FindElement(By.XPath("//a[text()='Customers']"));

    }

}
