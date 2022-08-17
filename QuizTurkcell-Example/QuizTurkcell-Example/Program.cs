using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTurkcell_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Turkcell Bilgi Yarışmasına Hoşgeldiniz");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if (soru == 1)
            {
                Console.WriteLine("Türkiye'nin başkenti neresidir?");
                Console.WriteLine();
                Console.WriteLine("A)İstanbul");
                Console.WriteLine("B)Ankara");
                Console.WriteLine("C)Bursa");
                Console.WriteLine("D)İzmir");

                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "B" || cevap == "b")
                {
                    soru = soru + 1;

                }

                else
                {
                    Console.Write("Maalesef , kaybettiniz");
                }

                if (soru == 2)
                {
                    Console.WriteLine("Atatürk ne zaman doğmuştur?");
                    Console.WriteLine();
                    Console.WriteLine("A)1880");
                    Console.WriteLine("B)1980");
                    Console.WriteLine("C)1981");
                    Console.WriteLine("D)1881");

                    Console.WriteLine();
                    Console.Write("Cevabınız: ");
                    cevap = Console.ReadLine();

                    if (cevap == "D" || cevap == "d")
                    {
                        soru = soru + 1;

                    }

                    else
                    {
                        Console.Write("Maalesef , kaybettiniz");
                    }
                }
                if (soru == 3)
                {
                    Console.WriteLine("Şanlıurfa' nın plakası kaçtır?");
                    Console.WriteLine();
                    Console.WriteLine("A)51");
                    Console.WriteLine("B)53");
                    Console.WriteLine("C)63");
                    Console.WriteLine("D)64");

                    Console.WriteLine();
                    Console.Write("Cevabınız: ");
                    cevap = Console.ReadLine();

                    if (cevap == "C" || cevap == "c")
                    {
                        Console.Write("Tebrikler , KAZANDINIZ !!");

                    }

                    else
                    {
                        Console.Write("Maalesef , kaybettiniz");
                    }
                }
                Console.Read();


            }


        }
    }
}
