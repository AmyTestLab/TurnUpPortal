using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Pages
{
    public class LoginPage
    {
        // Functions that allow users to login to TurnUp portal
        public void LoginActions(IWebDriver driver)
        {
            //launch turnupportal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();

            try
            {
                //identify username textbox and enter valid username 
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Username Textbox not found");
            }

            //Implicit wait
          //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
          //  var webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName"));

            //identify password textbox and enter valid password 
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");


            //identify login button and click it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }

        internal void LoginActions()
        {
            throw new NotImplementedException();
        }
    }
}
