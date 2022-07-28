using OpenQA.Selenium;


namespace Unacademy
{
    public class Start_learning : UtilityClass
    {
        private IWebDriver driver;

        private By Start_learning_Button = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
       
        
        private By Language_Learning_Link = By.XPath("//*[@id='TGITK']/p");
        private By Spoken_English = By.XPath("//*[@id='TGITK']/div/div[1]/div[2]/p[1]/span");
        
        public Start_learning(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartlearningButton()
        {
            driver.FindElement(Start_learning_Button).Click();
        }
        
        public void LanguageLearning()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement LanguageLearning = driver.FindElement(By.XPath("//*[@id='TGITK']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", LanguageLearning);
            driver.FindElement(Spoken_English).Click();
        }
        
        

                
       
        
    }
}
