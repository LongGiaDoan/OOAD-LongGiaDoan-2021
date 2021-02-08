using System;

namespace ConsoleBankautomaat
{
    class Program
    {
        static int antwoord;
        static double saldo = 500;
        static void Main(string[] args)

        {
            
           

            // keuze menu
            char keuze;
            Console.WriteLine("a. afhaling \nb. storting\nc. stoppen");
            keuze = Convert.ToChar(Console.ReadLine());

            switch (keuze)
            {
                case 'a': 
                    Console.WriteLine("je keuze : a");
                    geldAfhalen();
                    break;


                case 'b': 
                    Console.WriteLine("je keuze : b");
                    geldStorting();
                    break;

                case 'c': 
                    Console.WriteLine("bedankt en tot ziens");
                    break;

                

         
            }

          
        }

        static void geldAfhalen()
        {
            Console.WriteLine("welk bedrag wil je afhalen: ");
            antwoord =Convert.ToInt32( Console.ReadLine());
            // checken of afhaling mogelijk is 
            if(antwoord <= saldo)
            {
                saldo = saldo- antwoord;
                Console.WriteLine($"afhaling ok- nieuw saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("saldo ontoereikend");
            }
        }
        static void geldStorting()
        {
            Console.WriteLine("welk bedrag wil je storten: ");
            antwoord = Convert.ToInt32(Console.ReadLine());
            //storting
            saldo = saldo+antwoord;

            Console.WriteLine($"storting ok- nieuw saldo: {saldo}");
        }
    }
}
