using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
                //create a Employee record
                //click on create  button
                IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createButton.Click();
           
           
            //type name into code textbox
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Boney Varkey");

            //type username into username textbox

            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("boney");

            //type contact  into contact textbox
            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("ABC");

            //type password into password textbox
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("Boney@12345");

            //type retypepassword into retype password textbox

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("boney");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if  time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr/td[1]"));
            if (newEmployee.Text == "Boney Varkey")
            {
                Assert.Pass("Employee RECORD CREATED.");
            }
            else
            {
                Assert.Fail("EMPLOYEE RECORD HAS NOT BEEN CREATED.");
            }

        }
        public void EditEmployeeRecord(IWebDriver driver)
        {
            Thread.Sleep(4000);
            //Select a record and click edit button
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);


            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr/td[3]/a[1]"));
            editButton.Click();

            
                //create a Employee record
                //click on create  button
                IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createButton.Click();
          

            //type name into code textbox
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Boney Varkey");

            //type username into username textbox

            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("boney");

            //type contact  into contact textbox
            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("ABC");

            //type password into password textbox
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("Boney@12345");

            //type retypepassword into retype password textbox

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("boney");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if  time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr/td[1]"));
            if (newEmployee.Text == "Boney Varkey")
            {
                Assert.Pass("Employee RECORD CREATED.");
            }
            else
            {
                Assert.Fail("EMPLOYEE RECORD HAS NOT BEEN CREATED.");
            }
        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            Thread.Sleep(4000); Thread.Sleep(2000);
            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr/td[3]/a[2]"));
            deleteButton.Click();

            Thread.Sleep(1500);

            //Click OK to delete
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);

            driver.Navigate().Refresh();

            Thread.Sleep(4000);
            //Check if the record is deleted
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement deletedEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[20]/td[1]"));

            if (deletedEmployee.Text != "Boney Varkey")
            {
                Assert.Pass("Record deleted successfully");
            }
            else
            {
                Assert.Fail("Record has not been delete.");
            }
        }
    }
}
