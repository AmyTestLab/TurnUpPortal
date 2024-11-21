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
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();

            //check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("USER HAS LOGGED IN SUCCESSFULLY. TEST PASSED");
            }
            else
            {
                Console.WriteLine("USER HAS NOT LOGGED IN SUCCESSFULLY.TEST FAILED");
            }
        }
        
    }
}
