using OpenQA.Selenium;
using Yahoo.Helpers;

namespace Yahoo.Pages
{
    class HomePage : DriverHelper

    {

        IWebElement goToEmailsPage => webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ybarMailLink")));
        public void HomeElements()
        {
            goToEmailsPage.Click();
        }
    }
}
