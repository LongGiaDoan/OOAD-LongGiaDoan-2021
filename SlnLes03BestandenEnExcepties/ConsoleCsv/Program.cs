using System;
using System.IO;

namespace ConsoleCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spelers = new string[] { "Zakaria", "Saleha", "Ralph", "Francisco","Marie" };
            string[] spellen = new string[] { "schaak", "dammen", "backgammon"};
            Random rnd = new Random();
            string csvContent = "";
            int score1;
            int score2;


    

            for (int i = 1; i <= 10; i++)
            {
                string speler1 = spelers[rnd.Next(0, spelers.Length)];
                string speler2 = spelers[rnd.Next(0, spelers.Length)];
                string spel = spellen[rnd.Next(0, spellen.Length)];
                score1 = rnd.Next(0, 3);
                switch (score1)
                {
                    case 0: score2 = rnd.Next(0, 3);
                            break;
                    case 1: score2 = rnd.Next(0, 2);
                            break;
                    case 2: score2 = rnd.Next(0,1);
                            break;

                    default: score2 = 0;
                        break;

                }
                    
                    

                csvContent += $"{i};{speler1};{speler2};{spel};{score1}-{score2}{Environment.NewLine}";
            }



            // write to csv
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = System.IO.Path.Combine(folderPath, "shifts.csv");

            // open stream and start writing
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(csvContent);
            }

            // ok
            Console.WriteLine("csv generated");
            Console.ReadKey();

        }
    }

}

