using TechTalk.SpecFlow;




namespace Unacademy
{
    public class ApplicationHooks : UtilityClass
    {



        public Start_learning Sl;
        public LoginPage LP;
       

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
             LaunchApp(url);
            // LaunchApp(Url);

            Sl = new Start_learning(driver);
            driver.Manage().Window.FullScreen();

            LP = new LoginPage(driver);
            driver.Manage().Window.FullScreen();

           

            Thread.Sleep(5000);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(3000);
            CloseBrowser();
        }
        
    }
}




