using OpenQA.Selenium;


namespace Unacademy.Pages
{
    public class HomePage : UtilityClass
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//button[type='button']")).Click();

            
            this.driver = driver;
        }

    }
}
