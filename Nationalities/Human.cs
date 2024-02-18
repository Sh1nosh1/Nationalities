using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nationalities
{
    /// <summary>
    /// Abstract class of humans
    /// </summary>
    abstract class Human
    {
        /// <summary>
        /// Name and properties
        /// </summary>
        string name;
        public string Name { get => (name != "" && name != " ")? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Abstract method of greetings
        /// </summary>
        public abstract void Greetings();
    }
}
