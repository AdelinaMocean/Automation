using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Yahoo.Helpers;
using System.Threading.Tasks;
using System;

namespace Yahoo.Pages
{
    class LoginPage : DriverHelper


    {
     
 
        IWebElement usernameButton => driver.FindElement(By.Id("login-username"));
        IWebElement nextButton => driver.FindElement(By.Id("login-signin"));
        IWebElement passWordButton => webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("login-passwd")));
        public void DoLogin(string userName, string passWord)
        {
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Manage().Window.Maximize();
            driver.Url = "https://login.yahoo.com/";

            usernameButton.SendKeys(userName);
            nextButton.Click();
            passWordButton.SendKeys(passWord);
            nextButton.Click();
           
            
        }


    }
}
