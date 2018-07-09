using SnakesAndLadders;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SnakesAndLaddersTest
{
    [Binding]
    public class ObstaclesSteps
    {
        private Obstacles _obstacles;

        [BeforeScenario()]
        private void Initialize()
        {
            _obstacles = ObstaclesFactory.GetObstacles();
        }

        [Given(@"Player current square is (.*)")]
        public void GivenPlayerCurrentSquareIs(int square)
        {
            ScenarioContext.Current.Set<int>(square, "PlayerSquare");
        }
        
        [Given(@"he/she is going to move (.*) steps")]
        public void GivenHeSheIsGoingToMoveSteps(int steps)
        {
            ScenarioContext.Current.Set<int>(steps, "Steps");
        }
        
        [When(@"he/she moved")]
        public void WhenHeSheMoved()
        {
            var playerSquare = ScenarioContext.Current.Get<int>("PlayerSquare");
            var steps = ScenarioContext.Current.Get<int>("Steps");

            var squareAfterMoved = playerSquare + steps;

            _obstacles.EncounterObstacle(squareAfterMoved);
        }
        
        [Then(@"he/she should encounter obstacle and he/she would be square (.*)")]
        public void ThenHeSheShouldEncounterObstacleAndHeSheWouldBeSquare(int expected)
        {
            var actual = _obstacles.GetResultSquare();

            Assert.AreEqual(expected, actual);
        }
    }
}
