/*using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Start_Learning_Language_LearningStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is launched and Unacademy Application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Thread.Sleep(2000);
        }

        [When(@"User clicks on Startlearning Button")]
        public void WhenUserClicksOnStartlearningButton()
        {
            Thread.Sleep(2000);
            Sl.StartlearningButton();
        }

        [Then(@"It shows Home Page")]
        public void ThenItShowsHomePage()
        {
            Thread.Sleep(5000);
        }

        [When(@"User click on Language Learning")]
        public void WhenUserClickOnLanguageLearning()
        {
            Thread.Sleep(5000);
           Sl.LanguageLearning();
            Thread.Sleep(5000);

            driver.Quit();
         }
    }
}
*/