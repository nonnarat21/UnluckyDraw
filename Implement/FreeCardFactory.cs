using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluckyDraw.Interface;

namespace UnluckyDraw.Implement
{
    public class FreeCardFactory : ICardFactory
    {
        public override IDrawCard CreateDrawCard(int playerScore)
        {
            FreeCardDrawCard obj = new FreeCardDrawCard(playerScore);
            return obj;
        }

        public override IChangePlayerState CreateChangePlayerState()
        {
            FreeCardChangePlayerState obj = new FreeCardChangePlayerState();
            return obj;
        }
    }

    public class FreeCardDrawCard : IDrawCard
    {
        private int score;
        public FreeCardDrawCard(int cardScore)
        {
            score = 0;
        }

        public int GetPlayerScore(int playerScore)
        {
            return score;
        }
    }

    public class FreeCardChangePlayerState : IChangePlayerState
    {
        private string state;

        public FreeCardChangePlayerState()
        {
            state = "Stop";
        }

        public string ChangePlayerState()
        {
            return state;
        }
    }
}
