/*using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Login_ButtonStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome browser is launched and unacademy app is launched")]
        public void GivenChromeBrowserIsLaunchedAndUnacademyAppIsLaunched()
        {


            Console.WriteLine("Chrome browser is launched and unacademy app is launched");

        }
        [When(@"User click on '([^']*)' Button")]
        public void WhenUserClickOnButton(string login)
        {

            Thread.Sleep(1000);
            LP.LoginButton();
        }

        [Then(@"User navigate to '([^']*)' page")]
        public void ThenUserNavigateToPage(string login)
        {

            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

        }
    }
}
*/