using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluckyDraw.Implement
{
    public class Player
    {
        private string name;
        private int score;

        public Player(string playerName)
        {
            name = playerName;
            score = 0;
        }

        public void AddScore(int playerScore)
        {
            score = playerScore;
        }

        public int GetPlayerScore()
        {
            return score;
        }

        public string GetPlayerName()
        {
            return name;
        }
    }
}
