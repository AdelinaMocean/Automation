using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahoo.Helpers
{
    public class DriverHelper
    {
        public static IWebDriver driver { get; set; }
        public static WebDriverWait webDriverWait { get; set; }
       
    }
}
