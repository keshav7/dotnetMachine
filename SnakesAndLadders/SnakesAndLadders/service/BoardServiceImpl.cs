using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.models;

namespace SnakesAndLadders.service
{
    class BoardServiceImpl : IBoardService
    {
        Dictionary<String, Board> BoardsMap = new Dictionary<String, Board>();

        public BoardServiceImpl()
        {
        }

        public Board CreateBoard()
        {
            return new Board();
        }

        Dictionary<int, int> IBoardService.GetLadderPointsList(String BoardId)
        {
            if (BoardsMap.ContainsKey(BoardId))
            {
                return BoardsMap[BoardId].LadderPositions;
            }
            return null;
        }

        Dictionary<int, int> IBoardService.GetSnakePointList(String BoardId)
        {
            if (BoardsMap.ContainsKey(BoardId))
            {
                return BoardsMap[BoardId].SnakePositions;
            }
            return null;
        }
    }
}