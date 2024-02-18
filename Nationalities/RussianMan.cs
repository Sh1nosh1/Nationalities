using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nationalities
{
    /// <summary>
    /// Production class from Human
    /// </summary>
    class RussianMan : Human
    {
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public RussianMan() { }
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="name"></param>
        public RussianMan(string name) { Name = name; }
        /// <summary>
        /// Overriden method
        /// </summary>
        public override void Greetings()
        {
            WriteLine($"Привет, {Name}!");
        }
      }
}
