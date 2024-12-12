using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public delegate void FormInput(State s, string[] args);
    public delegate void UpdateForm(State s, string[] args);
}
