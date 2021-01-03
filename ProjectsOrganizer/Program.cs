using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Życie to pierdolony Projekt\nPodaj numer:\n" +
              "1-Wyswietl liste projektów\n" +
              "2-Dodaj projekt\n" +
              "3-Usun projekt\n" +
              "4-Dodaj update\n" +
              "5-Wyjdz z apki\n");

            var ifExit = false;
            string text = System.IO.File.ReadAllText(@"../../ProjectsData/DATA.txt");
            while (!ifExit)
            {
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: Console.WriteLine(text); break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: ifExit = true; break;
                    default:
                        break;
                }
            }
        }
    }
}
