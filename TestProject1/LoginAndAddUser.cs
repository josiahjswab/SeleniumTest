using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTesterson.TestCases
{
    class LoginTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test()
        {
            Console.WriteLine("====================================");

            driver = new ChromeDriver();
            driver.Url = "https://sqe-es17-1.mmspyxis.io";

            driver.FindElement(By.Id("details-button")).Click();
            driver.FindElement(By.Id("proceed-link")).Click();
            var userInput = driver.FindElement(By.Id("UserId"));
            userInput.Click();
            userInput.SendKeys("lwaltar");

            var passwordInput = driver.FindElement(By.Id("Password"));

            passwordInput.Click();
            passwordInput.SendKeys("Qaing");

            driver.FindElement(By.Id("signIn")).Click();

            Actions builder = new Actions(driver);
            //.MoveToElement(Tab you want to click element).Click().Build().Perform();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var menuSettings = wait.Until(ExpectedConditions.ElementExists(By.Id("Menu_Settings")));
            builder.MoveToElement(menuSettings).Click().Build().Perform();
            Console.WriteLine(menuSettings);

            var menuUsers = wait.Until(ExpectedConditions.ElementExists(By.Id("Menu_Users")));
            builder.MoveToElement(menuUsers).Click().Build().Perform();


            var menuUserAccounts = wait.Until(ExpectedConditions.ElementExists(By.Id("Menu_UserAccounts")));
            builder.MoveToElement(menuUserAccounts).Click().Build().Perform();

            var addUserButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='btnNewUser']/span")));
            addUserButton.Click();
            //*[@id="btnNewUser"]/span
            var addUserFirstName = driver.FindElement(By.Id("UserEditUserInput_FirstName"));

            addUserFirstName.Click();
            addUserFirstName.SendKeys("Added_With_Selenium");

            var addUserLastName = driver.FindElement(By.Id("UserEditUserInput_LastName"));

            addUserLastName.Click();
            addUserLastName.SendKeys("CCC_team");

            var addUserId = driver.FindElement(By.Id("UserEditUserInput_UserId"));

            addUserId.Click();
            addUserId.SendKeys("ccc");

            var addUserPassword = driver.FindElement(By.Id("UserEditUserInput_Password"));

            addUserPassword.Click();
            addUserPassword.SendKeys("123");

            Console.WriteLine("====================================");

            //driver.Quit();

        }
    }
}
