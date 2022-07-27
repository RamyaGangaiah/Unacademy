using OpenQA.Selenium;


namespace Unacademy
{
    public class Start_learning : UtilityClass
    {
        private IWebDriver driver;

        private By Start_learning_Button = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
        private By core_Engineering_Link = By.XPath("//*[@id='nav - container']/ul/li[26]/a/h4");
        private By SolidWork = By.XPath("//*[@id='DRAUB']/div/div[2]/div[2]/p[1]/span");
        private By Language_Learning_Link = By.XPath("//*[@id='TGITK']/p");
        private By Spoken_English = By.XPath("//*[@id='TGITK']/div/div[1]/div[2]/p[1]/span");
        private By Programming_for_students_Link = By.XPath("//*[@id='nav - container']/ul/li[24]/a/h4");
        private By Game_Development = By.XPath("//*[@id='OSIVA']/div/div/div[2]/p[1]/span");
        public Start_learning(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartlearningButton()
        {
            driver.FindElement(Start_learning_Button).Click();
        }
        /*
        public void LanguageLearning()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement LanguageLearning = driver.FindElement(By.XPath("//*[@id='TGITK']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", LanguageLearning);
            driver.FindElement(Spoken_English).Click();
        }
        
        public void coreEngineering()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement coreEngineering = driver.FindElement(By.XPath("//*[@id='DRAUB']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", coreEngineering);
            driver.FindElement(SolidWork).Click();

        }*/
        
        public void Programmingforstudents()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Programmingforstudents = driver.FindElement(By.CssSelector("#OSIVA > p"));
           // js.ExecuteScript("arguments[0].scrollIntoView(true);", Programmingforstudents);
            driver.FindElement(Game_Development).Click();
        }
        
    }
}
