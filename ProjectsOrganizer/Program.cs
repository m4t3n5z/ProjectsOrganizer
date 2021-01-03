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
            var info = "Życie to pierdolony Projekt\n\n\n" +
              "INFO\n" +
              "1-Wyswietl liste projektów\n" +
              "2-Dodaj projekt\n" +
              "3-Usun projekt\n" +
              "4-Dodaj update\n" +
              "5-ClearConsole\n" +
              "6-Wyjdz z apki\n";

            Console.WriteLine(info);

            var ifExit = false;
            //string text = System.IO.File.ReadAllText(@"../../ProjectsData/DATA.txt");
            while (!ifExit)
            {
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: Console.WriteLine("Oto nazwy projektów wraz z ich numeracją\n" +
                        System.IO.File.ReadAllText(@"../../ProjectsData/DATA.txt")); break;
                    case 2: 
                        break;
                    case 3: break;
                    case 4: break;
                    case 5: Console.Clear(); Console.WriteLine(info); break;
                    case 6: ifExit = true; break;
                    default: Console.WriteLine("Podałeś złą liczbę, Patrz INFO"); break;
                }
            }
        }
    }
}
