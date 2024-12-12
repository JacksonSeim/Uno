using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class SpecialCard : Card
    {
        public SpecialAbility Ability;

        public SpecialCard(Color c, bool indeck, SpecialAbility sa) : base(c, indeck)
        {
            Ability = sa;
        }
    }
}
