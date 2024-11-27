using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Pages
{
    public class HomePage
    {
        public void navigatetoTMPage(IWebDriver driver)
        {
            //navigate to time and material module
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();
            // Utilities.Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();

            //check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Assert.Pass("USER HAS LOGGED IN SUCCESSFULLY. TEST PASSED");
            }
            else
            {
                Assert.Fail("USER HAS NOT LOGGED IN SUCCESSFULLY.TEST FAILED");
            }
        }

        public void navigatetoEmployeePage(IWebDriver driver)
        {
            //navigate to Employee module
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();
            // Utilities.Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();

            //check if employee detais has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Assert.Pass("Employee details added successfully. TEST PASSED");
            }
            else
            {
                Assert.Fail("Employee details has not added successfully.TEST FAILED");
            }

        }

    }
}
