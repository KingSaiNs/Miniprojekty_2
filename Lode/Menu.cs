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
            Console.WriteLine("Co chcete udelat?");
            Console.WriteLine("HRAT, NASTAVENI,KONEC");

            string odpoved = Console.ReadLine();

            Hra mojeHra;

            if (odpoved.ToUpper() == "HRAT")
            {
                mojeHra = new Hra();
                mojeHra.SpustitHru();
            }
            else if (odpoved.ToUpper() == "NASTAVENI")
            {
               new NastaveniHry().OtevritNastaveni();
            }
            else if (odpoved.ToUpper() == "KONEC")
            {
                System.Environment.Exit(0); //ukončí program
            }
        }
    }
}