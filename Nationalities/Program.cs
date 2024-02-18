using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nationalities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Human> peoples = new List<Human>();
                peoples.Add(new RussianMan("Дарья"));
                peoples.Add(new Moldavian("Иоанн"));
                peoples.Add(new EnglishMan("Felix"));
                foreach (var elem in peoples) { elem.Greetings(); WriteLine(); }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
