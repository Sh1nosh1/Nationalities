using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Nationalities
{
    class EnglishMan : Human
    {
        public EnglishMan() { }
        public EnglishMan(string name) { Name = name; }
        public override void Greetings()
        {
            WriteLine($"Hello, {Name}!");
        }
    }
}
