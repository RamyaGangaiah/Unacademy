/*using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Login_AfterregisterStepDefinitions : ApplicationHooks
    {
        

        [Given(@"Chrome is launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {

            Thread.Sleep(2000);
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {

            Thread.Sleep(1000);
            LP.LoginButton();
        }

        [When(@"User enters Registered Phone Number (.*)")]
        public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
        {

            Thread.Sleep(1000);
            LP.MobileNumberTextBox(RegisteredPhoneNumber);
            LP.LoginButton1();
            Thread.Sleep(30000);
            LP.Verify_OTP_Button();
        }

        [Then(@"It shows home page")]
        public void ThenItShowsHomePage()
        {

            Thread.Sleep(5000);
            Console.WriteLine("Home Page Is Displayed");

        }
    }
}
*/