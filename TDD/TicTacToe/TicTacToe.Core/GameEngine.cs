using GameNetworkInterfaces;
using System;

namespace TicTacToe.Core
{   
    public class GameEngine
    {
        private ICommonGameNetworkControl _gameNetworkControl;

        public GameEngine(ICommonGameNetworkControl gameNetworkControl)
        {
            _gameNetworkControl = gameNetworkControl;
        }

        public string GetWinner(string[,] board)
        {
            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X")
            {
                return "X";
            }

            return " ";
        }

        public Guid Login(string username, string password)
        {
//            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
//            {
//                return Guid.Empty;
//            }

            return _gameNetworkControl.Login(username, password);
        }
    }
}
