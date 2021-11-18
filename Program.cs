using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Yahoo
{
    class Program
    {
        public Program(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebDriver _driver { get; set; }
        static void Main(string[] args)
        {

            Console.WriteLine("EnterUsername");
            var userName = Console.ReadLine();
            Console.WriteLine(userName);
            
        }
        public void Login()
        {

          
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.google.com/";
            Console.WriteLine("Enter text");
     
          IWebElement insertSerchText = _driver.FindElement(By.ClassName("gLFyf gsfi"));
            
        }

    }
    

}
