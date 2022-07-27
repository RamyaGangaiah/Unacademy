using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Login_JoinunacademyStepDefinitions : ApplicationHooks
    {
        [When(@"User enters Mobile Number (.*)")]
        public void WhenUserEntersMobileNumber(string MobileNumber)
        {
            LP.MobileNumberTextBox(MobileNumber);
        }

        [When(@"User enter Continue button")]
        public void WhenUserEnterContinueButton()
        {
            LP.ContinueButton();
        }

        [Then(@"It shows Verify your mobile number page")]
        public void ThenItShowsVerifyYourMobileNumberPage()
        {
            Thread.Sleep(3000);
           
        }
    }
}
