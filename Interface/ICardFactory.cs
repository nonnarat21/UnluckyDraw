using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluckyDraw.Interface
{
    public abstract class ICardFactory
    {
        public abstract IDrawCard CreateDrawCard(int playerScore);

        public abstract IChangePlayerState CreateChangePlayerState();
    }

    public interface IDrawCard
    {
        int GetPlayerScore(int score);
    }

    public interface IChangePlayerState
    {
        string ChangePlayerState();
    }

}
