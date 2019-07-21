using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluckyDraw.Interface;

namespace UnluckyDraw.Implement
{
    public class CardFactoryProvider
    {
        public static ICardFactory GetCardFactory(string cardType)
        {
            if (cardType == "F") { return new FreeCardFactory(); }
            else
            if (cardType == "S") { return new StackCardFactory(); }
            else
            if (cardType == "P") { return new PointCardFactory(); }
            else
                return null;
        }
    }
}
