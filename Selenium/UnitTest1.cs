using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium
{
    public class Tests
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
           driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("q")).SendKeys("Akash");
        }


        [Test]
        public void Test2()
        {
            driver.FindElement(By.Name("q")).Clear;
            driver.FindElement(By.Name("q")).SendKeys("Akash123456");
        }


        [OneTimeTearDown]
        public void Close()
        {
            driver.Close();
        }






    }

}
}