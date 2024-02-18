using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nationalities
{
    class RussianMan : Human
    {
        public RussianMan() { }
        public RussianMan(string name) { Name = name; }
        public override void Greetings()
        {
            WriteLine($"Привет, {Name}!");
        }
    }
}
