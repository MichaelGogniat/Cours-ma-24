using System;
using System.Collections.Generic;

namespace Gestion_d_une_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Montagne = new List<string>(){
            "Haute Cime",
            "Stellihorn",
             "Grand Muvran"
            };

            Montagne.Add("Dent de Corjon");
            Montagne.Remove("Grand Muvran");
            for (int i = 0; i < Montagne.Count; i++)
            {
                Console.WriteLine(Montagne[i]);
            }
            Console.ReadKey();
        }
    }
}
