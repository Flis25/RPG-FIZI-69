using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_FIZI_69
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            bool zivot = true;
            Dictionary<string, int> staty = new Dictionary<string, int>()
            {
                { "STR", 10 },
                { "DEX", 10 },
                { "INT", 10 }
            };
            Console.WriteLine("Zadej jméno:");
            string jmeno = Console.ReadLine();
            int unava = 0;
            int level = 1;
            int cislo = 10;
            int cas = 1;
            while(zivot == true)
            {
                Console.WriteLine($"Jsi unaven na {unava}% ");
                Console.WriteLine("Chcete jtít na quest nebo se jít vyspat? Q/S");
                string anone = Console.ReadLine();
                if(anone == "Q")
                {
                    Console.WriteLine($"Vydáváš se na quest, vrat se za {cislo} sekund");
                    cislo = cislo + 10;
                    unava = unava + 10;
                    level = level + 1;
                    Thread.Sleep(10000 * cas );
                    cas = cas + 1;

                }
                else
                {
                    Console.WriteLine("Spíš ☻");
                    cas = 1;
                    unava = 0;

                }
            }
            
            
        }
    }
}

