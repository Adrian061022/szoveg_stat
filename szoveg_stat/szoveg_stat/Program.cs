using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_stat
{
    class Program
    {

        static int Megszamolas(string a) {

            int db = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    db++;
                }
            }
            return db;
        
        }

        static void Kiir(int a, int v) {

            Console.WriteLine($"A szöveg {a} szóbol áll");
            Console.WriteLine(v);
        
        }
        static string Vissza(string s) {

            string vissza = "";
            for (int i = s.Length-1; i >0,i--)
            {
                vissza += i;
            }
            return vissza;
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy mondatot");
            string mondat = Console.ReadLine();

            int megszamolas = Megszamolas(mondat);
            Kiir(megszamolas);
            string vissza = Vissza(mondat);

            Console.WriteLine("nyomj egy billentyűt");
            Console.ReadKey(true);
            
        }
    }
}
