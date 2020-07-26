using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.models;

namespace SnakesAndLadders.service
{
    interface IBoardService
    {

        Dictionary<int, int> GetSnakePointList(String boardId);
        Dictionary<int, int> GetLadderPointsList(String boardId);
        Board CreateBoard();
        //void UpdatePlayerPosition(String boardId, String player, int position);
        //Dictionary<String, int> GetPlayPositionMap(String boardId);
    }
}
