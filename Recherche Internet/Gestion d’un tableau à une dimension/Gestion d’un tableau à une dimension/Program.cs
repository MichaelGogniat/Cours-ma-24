using System;

namespace Gestion_d_un_tableau_à_une_dimension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableau= { "tableau", "tableau", "tableau", "tableau" };

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = tableau[i] + " " + i;
            }

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
            Console.ReadKey();
        }
    }
}
