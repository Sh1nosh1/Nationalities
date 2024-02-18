using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Nationalities
{
    /// <summary>
    /// Production class from Human
    /// </summary>
    class Moldavian : Human
    {
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Moldavian() { }
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="name">Moldavian name</param>
        public Moldavian(string name) { Name = name; }
        /// <summary>
        /// Overriden method
        /// </summary>
        public override void Greetings()
        {
            WriteLine($"Бунэ зиуа, {Name}!");
        }
      }
}
