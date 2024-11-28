using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
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
            homePageObj.navigatetoTMPage(driver);
        }
        [Test]
        public void CreateTime_Test()
        {
            //TM page object initialisation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test()
        {
            // Edit Time Record

            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver, "New Code", "Updated description");
            // tMPageObj.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Test()
        {
            // Delete Time Record

            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
         {
           driver.Quit();
         }

    }
}
