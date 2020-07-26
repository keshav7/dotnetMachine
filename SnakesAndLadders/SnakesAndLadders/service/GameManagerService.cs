using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.models;

namespace SnakesAndLadders.service
{
    class GameManagerService : IGameManagerService
    {
        private IGameService GameService;
        private IBoardService BoardService;
        private Random random = new Random();

        public Dictionary<String, List<String>> GameHistory { get; set; }

        public GameManagerService(IGameService GameService, IBoardService BoardService)
        {
            this.GameService = GameService;
            this.BoardService = BoardService;
            GameHistory = new Dictionary<string, List<string>>();
        }

        public void PlayNewGame()
        {
            Board Board = BoardService.CreateBoard();
            Game Game = GameService.Create(Board.ID);
            GameHistory.Add(Game.ID, new List<string>());
            Boolean isComplete = false;

            while(!isComplete)
            {
                int DiceValue = random.Next(1, 7);
                int Position = Game.PlayerMap["1"] + DiceValue;
                GameHistory[Game.ID].Add("1, " + Game.PlayerMap["1"] + " : " + Position);
                if (Position < 100)
                {
                    if (BoardService.GetSnakePointList(Board.ID).ContainsKey(Position)) 
                    {


                    } 
                }


            }
        }
    }
}
