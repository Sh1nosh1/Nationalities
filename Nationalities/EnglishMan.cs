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
    class EnglishMan : Human
    {
        /// <summary>
        /// Constractor without parameters
        /// </summary>
        public EnglishMan() { }
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="name">English name</param>
        public EnglishMan(string name) { Name = name; }
        /// <summary>
        /// Overriden method
        /// </summary>
        public override void Greetings()
        {
            WriteLine($"Hello, {Name}!");
        }
      }
}
