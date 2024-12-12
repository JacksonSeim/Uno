using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class NumberCard : Card
    {
        public int Number;

        public NumberCard(Color c, bool indeck, int num) : base(c, indeck)
        {
            Number = num;
        }
    }
}
