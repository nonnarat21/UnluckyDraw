using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluckyDraw.Interface;

namespace UnluckyDraw.Implement
{
    public class StackCardFactory : ICardFactory
    {
        public override IDrawCard CreateDrawCard(int playerScore)
        {
            StackCardDrawCard obj = new StackCardDrawCard(playerScore);
            return obj;
        }

        public override IChangePlayerState CreateChangePlayerState()
        {
            StackCardChangePlayerState obj = new StackCardChangePlayerState();
            return obj;
        }
    }

    public class StackCardDrawCard : IDrawCard
    {
        private int score;
        public StackCardDrawCard(int cardScore)
        {
            score = cardScore;
        }

        public int GetPlayerScore(int playerScore)
        {
            return playerScore + score;
        }
    }

    public class StackCardChangePlayerState : IChangePlayerState
    {
        private string state;

        public StackCardChangePlayerState()
        {
            state = "Continue";
        }

        public string ChangePlayerState()
        {
            return state;
        }
    }
}
