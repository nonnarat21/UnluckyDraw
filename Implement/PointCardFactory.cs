using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluckyDraw.Interface;

namespace UnluckyDraw.Implement
{
    public class PointCardFactory : ICardFactory
    {
        public override IDrawCard CreateDrawCard(int playerScore)
        {
            PointCardDrawCard obj = new PointCardDrawCard(playerScore);
            return obj;
        }

        public override IChangePlayerState CreateChangePlayerState()
        {
            PointCardChangePlayerState obj = new PointCardChangePlayerState();
            return obj;
        }
    }

    public class PointCardDrawCard : IDrawCard
    {
        private int score;
        public PointCardDrawCard(int cardScore)
        {
            score = cardScore;
        }

        public int GetPlayerScore(int playerScore)
        {
            return playerScore + score;
        }
    }

    public class PointCardChangePlayerState : IChangePlayerState
    {
        private string state;

        public PointCardChangePlayerState()
        {
            state = "Stop";
        }

        public string ChangePlayerState()
        {
            return state;
        }
    }
}
