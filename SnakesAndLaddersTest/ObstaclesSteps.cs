using System;
using TechTalk.SpecFlow;

namespace SnakesAndLaddersTest
{
    [Binding]
    public class ObstaclesSteps
    {
        [BeforeScenario()]
        private void Initialize()
        {

        }

        [Given(@"Player current square is (.*)")]
        public void GivenPlayerCurrentSquareIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"he/she is going to move (.*) steps")]
        public void GivenHeSheIsGoingToMoveSteps(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"he/she moved")]
        public void WhenHeSheMoved()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"he/she should encounter obstacle and he/she would be square (.*)")]
        public void ThenHeSheShouldEncounterObstacleAndHeSheWouldBeSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
