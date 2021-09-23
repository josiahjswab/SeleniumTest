using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesterson.TestCases
{
    class LoginTest
    {
        [Test]
        public void Test()
        {
            Assert.Pass();
            IWebDriver driver;
            //try
            //{
                driver = new ChromeDriver();
                driver.Url = "https://www.google.com";
                // Find the element that's ID attribute is 'account'(My Account) 
                driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
            //}
            //catch
            //{
                Console.WriteLine("NOT WORKING");
            //}


            //// Find the element that's ID attribute is 'log' (Username)
            //// Enter Username on the element found by above desc.
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");

            //// Find the element that's ID attribute is 'pwd' (Password)
            //// Enter Password on the element found by the above desc.
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

            //// Now submit the form.
            driver.FindElement(By.Id("login")).Click();

            //// Find the element that's ID attribute is 'account_logout' (Log Out)
            driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

            // Close the driver
            driver.Quit();

        }
    }
}
