using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.models;

namespace SnakesAndLadders.service
{
    class GameService : IGameService
    {
        Dictionary<String, Game> Games;

        public GameService()
        {
            Games = new Dictionary<string, Game>();
        }

        Game IGameService.Create(string BoardId)
        {
            Game Game = new Game(BoardId);
            Games.Add(Game.ID, Game);
            return Game;

        }

        Game IGameService.GetGame(string ID)
        {
            if (Games.ContainsKey(ID))
            {
                return Games[ID];
            }
            return null;
        }

        void IGameService.UpdateGame(string GameId, Game Game)
        {
            if (Games.ContainsKey(GameId))
            {
                Games[GameId] = Game;
            }
        }
    }
}
