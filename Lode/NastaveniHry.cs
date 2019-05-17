using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class NastaveniHry
    {
        public void OtevritNastaveni()
        {
            Console.WriteLine("Jakou chcete barvu pozadí?");

            List<ConsoleColor> seznamBarev = new List<ConsoleColor>();

            seznamBarev.Add(ConsoleColor.Black);
            seznamBarev.Add(ConsoleColor.Blue);

            for(int i = 0; i < seznamBarev.Count; i++)
            {
                Console.WriteLine("Volba " + i + ": " + seznamBarev[i]);
            }

            
            Console.ReadKey();
        }
    }
}
