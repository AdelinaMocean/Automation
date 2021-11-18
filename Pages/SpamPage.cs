using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Yahoo.Helpers;


namespace Yahoo.Pages
{
    class SpamPage : DriverHelper
    {

           
        

        #region Elements
        IWebElement spamButton => driver.FindElement(By.XPath("//*[text()='Spam']"));
        #endregion
        public void GoToSpamEmails() 
        {           
            spamButton.Click();
        }
     
        public void CheckForSpamEmails()
        {
            try
            {
                if (driver.FindElements(By.XPath("//*[text()='” este gol']")).Count != 0)
                {
                    Console.WriteLine("No emails in Spam");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("There are emails in Spam");
                    Assert.Fail();
                }
            }
            catch(Exception)
            {

            }


        }
    }
}
