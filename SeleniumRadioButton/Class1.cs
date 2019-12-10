
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



namespace SeleniumRadioButton
{
    class Class1
    {
        IWebDriver driver;

      
        [Test]
        public void TestRegister()
        {
            GoToWebsite("http://qa.todorovic.net/, true");
            IWebElement linkRegister;
            linkRegister = FindElement(By.PartialLinkText("Registruj"));
            if (linkRegister != null)
            {
                linkRegister.Click();
            }
           
            FindElement(By.Id("pol_m"))?.Click();
            Sleep(3);

        }

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        public void Sleep(int ms = 1000)
        {
            System.Threading.Thread.Sleep(ms);
        }

        public void GoToWebsite(string url, bool wait = false)
        {
            if (wait) { Sleep(); }
            driver.Navigate().GoToUrl(url);
            if (wait) { Sleep(); }
        }

        public IWebElement FindElement(By selector)
        {
            IWebElement elReturn = null;
            try
            {
                elReturn = driver.FindElement(selector);
            }
            catch (NoSuchElementException)
            {

            }
            catch (Exception e)
            {
                throw e;
            }

            return elReturn;
        }
    }
}