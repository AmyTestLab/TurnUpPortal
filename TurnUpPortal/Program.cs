using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TurnUpPortal.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser
        IWebDriver driver = new ChromeDriver();

        

        //Login page object initialisation and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page object initialisation and definition
        HomePage homePageObj = new HomePage();
        homePageObj.navigatetoTMPage(driver);

        //TM page object initialisation and definition
        TMPage tMPageObj = new TMPage();
        tMPageObj.createTimeRecord(driver);

        tMPageObj.editTimeRecord(driver);
        tMPageObj.deleteTimeRecord(driver);

      
    }
}