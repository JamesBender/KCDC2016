using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Game;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeGameEngineSteps
    {
        private string[,] _board;
        private GameEngine _gameEngine = new GameEngine();
        private string _result;

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new String[3,3];
        }

        [Given(@"the board is empty")]
        public void GivenTheBoardIsEmpty()
        {
            _board = new string[3, 3] {{" ", " ", " "}, {" ", " ", " "}, {" ", " ", " "}};

        }

        [When(@"I determine the outcome")]
        public void WhenIDetermineTheOutcome()
        {
            _result = _gameEngine.GetWinner(_board);
        }

        [Then(@"the the result should be a stalemate")]
        public void ThenTheTheResultShouldBeAStalemate()
        {
            Assert.AreEqual(" ", _result);
        }

        [Given(@"the top row is all ""(.*)""")]
        public void GivenTheTopRowIsAll(string p0)
        {
            _board[0, 0] = p0;
            _board[0, 1] = p0;
            _board[0, 2] = p0;
        }

        [Then(@"the result is ""(.*)"" is the winner")]
        public void ThenTheResultIsIsTheWinner(string p0)
        {
            Assert.AreEqual(p0, _result);
        }

        [Given(@"the board looks like this")]
        public void GivenTheBoardLooksLikeThis(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
