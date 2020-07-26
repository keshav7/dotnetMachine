using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.models
{

    enum State { CREATED, COMPLETED };

    class Game
    {
        public String ID { get; set; }

        public String BoardId { get; set; }

        public Dictionary<String, int> PlayerMap { get; set; }

        public State GameState;

        private Random random = new Random();

        public Game(String BoardId)
        {
            ID = new Guid().ToString();
            this.BoardId = BoardId;
            PlayerMap = new Dictionary<String, int>();

            // can make this better
            PlayerMap.Add("1", 0);
            PlayerMap.Add("2", 0);
            GameState = State.CREATED;
        }
    }
}
