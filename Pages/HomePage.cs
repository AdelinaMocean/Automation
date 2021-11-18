using OpenQA.Selenium;
using Yahoo.Helpers;

namespace Yahoo.Pages
{
    class HomePage : DriverHelper

    {

        IWebElement goToEmailsPage => driver.FindElement(By.Id("ybarMailLink"));
        public void HomeElements()
        {
            goToEmailsPage.Click();
        }
    }
}
