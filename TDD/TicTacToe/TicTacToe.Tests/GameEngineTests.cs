using System;
using GameNetworkInterfaces;
using Moq;
using NUnit.Framework;
using TicTacToe.Core;

namespace TicTacToe.Tests
{
    [TestFixture]
    class GameEngineTests
    {
        private GameEngine _gameEngine;
        private string[,] _board;
        private Mock<ICommonGameNetworkControl> _gameNetorkMock;

        [SetUp]
        public void SetupTests()
        {
            _gameNetorkMock = new Mock<ICommonGameNetworkControl>();

            _gameEngine = new GameEngine(_gameNetorkMock.Object);
            _board = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }

        [Test]
        public void WhenTheBoardIsEmptyThenThereIsNoCurrentWinner()
        {
            var expectedResult = " ";
                        
            var result = _gameEngine.GetWinner(_board);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenTheTopRowIsAllXThenXShouldWin()
        {
            var expectedResult = "X";
            _board[0, 0] = "X";
            _board[0, 1] = "X";
            _board[0, 2] = "X";
            
            var result = _gameEngine.GetWinner(_board);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenAUserSuppliesAGoodUserNameAndPasswordTheyAreLoggedIn()
        {
            var username = "Bob";
            var password = "12345";
            var expectedSessionToken = Guid.NewGuid();

            _gameNetorkMock.Setup(x => x.Login(username, password)).Returns(expectedSessionToken);

            var result = _gameEngine.Login(username, password);

            Assert.AreEqual(expectedSessionToken, result);
        }

        [Test]
        public void WhenAUserNameIsSuppliedButAPasswordIsNotThenGetAnEmptySessionToken()
        {
            var username = "Bob";
            var password = string.Empty;
            var expectedSessionToken = Guid.Empty;

            _gameNetorkMock.Setup(x => x.Login(username, password)).Throws<ArgumentException>();

            var result = _gameEngine.Login(username, password);

            Assert.AreEqual(expectedSessionToken, result);
        }
    }
}
