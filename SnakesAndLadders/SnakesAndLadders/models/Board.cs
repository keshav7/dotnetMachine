using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.models
{
    public class Board
    {
        private const int NUMBER_SNAKE_POSITIONS = 12;
        private const int NUMBER_LADDER_POSITIONS = 12;

        public string ID { get; set; }
        public Dictionary<int, int> SnakePositions { get; set; }
        public Dictionary<int, int> LadderPositions { get; set; }
        private readonly Random random = new Random();

        public Board()
        {
            ID = Guid.NewGuid().ToString();
            SnakePositions = new Dictionary<int, int>();
            LadderPositions = new Dictionary<int, int>();
            InitSnakePositionsList();
            InitLadderPositionsList();
        }

        private void InitSnakePositionsList()
        {
            int i = 0;
            while (i < NUMBER_SNAKE_POSITIONS)
            {
                int RandomPosition = random.Next(100);
                if (SnakePositions[RandomPosition] != null)
                {
                    SnakePositions.Add(RandomPosition, random.Next(1, RandomPosition));
                    i++;
                }
            }
        }

        private void InitLadderPositionsList()
        {
            int i = 0;
            while (i < NUMBER_LADDER_POSITIONS)
            {
                int RandomPosition = random.Next(100);
                if (LadderPositions[RandomPosition] != null)
                {
                    LadderPositions.Add(RandomPosition, random.Next(RandomPosition + 1, 100 - RandomPosition));
                    i++;
                }
            }
        }

    }
}
