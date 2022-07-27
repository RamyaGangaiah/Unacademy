/*using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Login_RegisterStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is launched and Unacademy app is Launched")]
        public void GivenChromeIsLaunchedAndUnacademyAppIsLaunched()
        {
            Thread.Sleep(2000);
        }

        [When(@"User clicks on Login Button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@aria-label='Login']"));
            loginButton.Click();
        }

        [When(@"User clicks on Create your account Link")]
        public void WhenUserClicksOnCreateYourAccountLink()
        {
            Thread.Sleep(2000);
             
        }

        [Then(@"It Shows Join Unacademy Page")]
        public void ThenItShowsJoinUnacademyPage()
        {
            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            Thread.Sleep(2000);
            
        }

        [When(@"User Enters Mobile Number (.*)")]
        public void WhenUserEntersMobileNumber(string mobilenumber)
        {
            LP.MobileNumberTextBox(mobilenumber);
        }

        [When(@"User enter Continue Button")]
        public void WhenUserEnterContinueButton()
        {
            LP.ContinueButton();
        }

        [Then(@"It Shows Enter OTP Page")]
        public void ThenItShowsEnterOTPPage()
        {
            Thread.Sleep(6000);
        }

        [When(@"User enter Name ""([^""]*)""")]
        public void WhenUserEnterName(string Name)
        {
            LP.NameTextBox(Name);
        }

        [When(@"User enter Email address""([^""]*)""")]
        public void WhenUserEnterEmailAddress(string Emailaddress)
        {
            LP.EmailaddressTextBox(Emailaddress);
        }

        [When(@"User Select-State of residence Karnataka")]
        public void WhenUserSelect_StateOfResidenceKarnataka()
        {
            LP.SelectStateofresidenceDropdown();
        }

        [When(@"User Click on checkbox")]
        public void WhenUserClickOnCheckbox()
        {
            LP.checkBox();
        }

        [When(@"User click on Submit button")]
        public void WhenUserClickOnSubmitButton()
        {
            LP.SubmitButton();
        }

        [Then(@"It shows HomePage")]
        public void ThenItShowsHomePage()
        {
            Thread.Sleep(3000);
        }
    }
}
*/