using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static List<noveny> list = new List<noveny>();
        static Dictionary<string, int> gk = new Dictionary<string, int>();
        static void ol()
        {
            StreamReader ol = new StreamReader("noveny.csv");
            while (!ol.EndOfStream)
            {
                string sda = ol.ReadLine();
                list.Add(new noveny(sda));
            }
            ol.Close();
        }
        static void dic()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (gk.ContainsKey(list[i].resz))
                {
                    gk[list[i].resz]++;
                }
                else
                {
                    gk.Add(list[i].resz, 1);
                }
            }
        }
        static int maxta()
        {
            int maxta = list[0].tartam;
            for (int i = 1; i < list.Count; i++)
            {
                if (maxta<list[i].tartam)
                {
                    maxta = list[i].tartam;
                }
            }
            return maxta;
        }
        static double atl()
        {
            double atl = 0;
            foreach (var item in list)
            {
                atl += item.tartam;
            }
            atl = atl / list.Count;
            Math.Round(atl, 2);
            return atl;
        }
        static void Main(string[] args)
        {
            ol();
            Console.WriteLine("1. feladat: Növények száma: {0}\n",list.Count);
            Console.WriteLine("2. feladat: Gyűjthető részek:");
            dic();
            foreach (var item in gk)
            {
                Console.WriteLine("{0}: {1}",item.Key,item.Value);
            }
            
            Console.WriteLine();
            int s = maxta();
            Console.WriteLine("3. feladat:Legtöbb idő amíg gyűjthető:{0}\nNövény(ek):",s);
            foreach (var item in list)
            {
                if (item.tartam==s)
                {
                    Console.WriteLine(item.nev);
                }
            }
            Console.WriteLine();
            Console.WriteLine("4. feladat: Átlagos gyűjthető időtartam: {0}",atl());
            Console.ReadKey();
        }
    }
}
