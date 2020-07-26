using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.models;

namespace SnakesAndLadders.service
{
    interface IGameService
    {
        Game Create(String BoardId);

        Game GetGame(String ID);

        void UpdateGame(String GameId, Game Game);


    }
}
