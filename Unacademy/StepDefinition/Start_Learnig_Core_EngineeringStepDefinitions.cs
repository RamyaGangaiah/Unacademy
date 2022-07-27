/*using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinition
{
    [Binding]
    public class Start_Learnig_Core_EngineeringStepDefinitions : ApplicationHooks
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

            Thread.Sleep(3000);

        }

        [When(@"User click on core Engineering")]
        public void WhenUserClickOnCoreEngineering()
        {
            Thread.Sleep(3000);
            Sl.coreEngineering();

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
*/