using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamDarabolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szamot: ");
            string szam = Console.ReadLine();
            List<string> szamok = new List<string>();
            for (int i = 0; i <= szam.Length-1; i++)
            {
                szamok.Add(szam[i].ToString());
            }
            List<string> szamok_distinct = szamok;
            szamok_distinct=szamok_distinct.Select(x => x).Distinct().OrderBy(x=>x).ToList();
            for (int i = 0; i <=szamok_distinct.Count()-1; i++)
            {
                int ooo = 0;
                for (int a = 0; a <= szamok.Count() - 1; a++)
                {
                    if (szamok_distinct[i]==szamok[a])
                    {
                        ooo++;
                    }
                    
                }
                Console.WriteLine($"{szamok_distinct[i]}: {ooo} db van");
            }
            Console.ReadKey();
        }
    }
}
