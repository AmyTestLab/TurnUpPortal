﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Tests
{
    [TestFixture]
    public class Employee_Tests : CommonDriver
    {

        [SetUp]
        public void SetUpSteps()
        {
            //open chrome browser
            driver = new ChromeDriver();

            //Login page object initialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.navigatetoEmployeePage(driver);
        }
        [Test]
        public void CreateEmployeeRecord()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployeeRecord(driver);
        }
        [Test]
        public void EditEmployeeRecord()
        {
            // Edit Time Record
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployeeRecord(driver);

        }
        [Test]
        public void DeleteEmployeeRecord()
        {
            // Delete Time Record
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployeeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
