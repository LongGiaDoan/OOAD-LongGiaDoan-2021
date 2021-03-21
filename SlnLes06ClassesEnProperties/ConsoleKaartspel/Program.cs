using System;

namespace ConsoleKaartspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaart kaart1 = new Kaart(7,"S");
            Console.WriteLine(kaart1.kleur);
            
        }
    }
}
