using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium.CustomMethods
{
    internal class BaseClass
    {
        IWebDriver driver;
        public void enterText(IWebElement ele, String value)
        {
            ele.Click();
            ele.Clear();    
            ele.SendKeys(value);
        }

        public void selectFromDropdown(IWebElement ele, String text)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByText(text);
        }
        public void selectFromDropdown(IWebElement ele, int index)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByIndex(index);
        }

        public void selectFromDropdown( String value, IWebElement ele)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByValue(value);
        }

        public void rightClick()
        {
            Actions action = new Actions(driver);
            action.ContextClick().Build().Perform();
        }

    }
}
