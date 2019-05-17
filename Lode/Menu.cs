using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Menu
    {
        public void Vocas()
        {
            Console.WriteLine("Co chcete udělat?");
            Console.WriteLine("HRÁT, NASTAVENÍ,KONEC");

            string odpoved = Console.ReadLine();

            Hra mojeHra;

            if (odpoved.ToUpper() == "HRÁT")
            {
                Console.Clear();
                mojeHra = new Hra();
                mojeHra.SpustitHru();
            }
            else if (odpoved.ToUpper() == "NASTAVENÍ")
            {
               new NastaveniHry().OtevritNastaveni();
                Console.Clear();
            }
            else if (odpoved.ToUpper() == "KONEC")
            {
                System.Environment.Exit(0); //ukončí program
            }
        }
    }
}