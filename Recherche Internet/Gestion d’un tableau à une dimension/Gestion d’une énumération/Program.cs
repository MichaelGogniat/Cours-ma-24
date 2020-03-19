using System;

namespace Gestion_d_une_énumération
{
    class Program
    {
        public enum lettre
        {
            A,B,C,D,E
        }


        static void Main(string[] args)
        {
            string a = lettre.A.ToString();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
