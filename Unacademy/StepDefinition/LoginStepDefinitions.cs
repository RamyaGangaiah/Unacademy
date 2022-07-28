using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class LoginStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is Launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }

        [When(@"User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Thread.Sleep(1000);
            LP.LoginButton();
        }

        [When(@"User enters Registered Phone number ""([^""]*)""")]
        public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
        {
            Thread.Sleep(1000);
            LP.EnteryourmobilenumberTextBox(RegisteredPhoneNumber);
            LP.LoginButton1();
            Thread.Sleep(30000);
            LP.Verify_OTP_Button();
        }

        [Then(@"It shows home Page")]
        public void ThenItShowsHomePage()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Home Page Is Displayed");
        }

        [Given(@"Chrome is launched and Unacademy Application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched1()
        {
            Console.WriteLine("Chrome browser is launched and unacademy app is launched");
        }

        [When(@"User clicks on Startlearning Button")]
        public void WhenUserClicksOnStartlearningButton()
        {
            Thread.Sleep(3000);
            Sl.StartlearningButton();
        }
        
       

        [Then(@"It shows Home Page")]
        public void ThenItShowsHomePage1()
        {
            Thread.Sleep(3000);
        }
        
        
        
        [When(@"User click on Language Learning")]
        public void WhenUserClickOnLanguageLearning()
        {
            Thread.Sleep(5000);
            Sl.LanguageLearning();
            Thread.Sleep(5000);
        }
       
    }
}
