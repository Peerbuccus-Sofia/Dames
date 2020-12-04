using System;

namespace Dames
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau damier = new Plateau();
            Pion pions = new Pion();
            Console.WriteLine("Commencer une partie ! ");
            damier.Damier();
            //Console.ReadKey(true);
        }
    }
}
