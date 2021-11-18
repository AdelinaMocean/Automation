using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Yahoo.Helpers;
using Yahoo.Pages;

namespace Yahoo
{  
    class MainTest : DriverHelper

    {


        [SetUp]
        public void TestLoggin()
        {
            
            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage();
            loginPage.DoLogin("mocean_adelina@yahoo.com", "Xklm12@tazz");
        }


     [Test]
        public void CheckSpam()
        {  
            SpamPage spamPage = new SpamPage();
            HomePage homePage = new HomePage();
            homePage.HomeElements();
            spamPage.GoToSpamEmails();
            spamPage.CheckForSpamEmails();

     
        }
    }
}
