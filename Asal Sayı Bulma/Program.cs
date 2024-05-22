using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayı_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Üst limiti giriniz:");
              int ustSayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("Alt limiti giriniz:");
              int altSayi = Convert.ToInt32(Console.ReadLine());

            if (altSayi >= 2)
            {
                for (int i = altSayi; i <= ustSayi; i++)
                {
                    int bölünenSayılar = 0;

                    for (int j = 2;j<=Math.Sqrt(i) ; j++)
                    {
                        if (i % j == 0)
                            bölünenSayılar++;
                    }
                    if (bölünenSayılar == 0)
                        Console.Write("{0}\t", i);
                }
            }
            Console.ReadLine();

        }
    }
}
