using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Login_createyouraccountStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome browser is launched and unacademy app is launched")]
        public void GivenChromeBrowserIsLaunchedAndUnacademyAppIsLaunched()
        {
            Thread.Sleep(2000);
        }

        [When(@"User click on '([^']*)' Button")]
        public void WhenUserClickOnButton(string login)
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@aria-label='Login']"));
            loginButton.Click();
        }

        [Then(@"User navigate to '([^']*)' page")]
        public void ThenUserNavigateToPage(string login)
        {

            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            Thread.Sleep(2000);
        }

        [When(@"User click on '([^']*)' Link")]
        public void WhenUserClickOnLink(string p0)
        {
              LP.createyouraccountLink();
        }

        [Then(@"It shows '([^']*)' Page")]
        public void ThenItShowsPage(string p0)
        {

            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
