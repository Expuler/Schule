using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aufgabe4();
        }

        static void Aufgabe1()
        {
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x += 2;
            }
        }
        static void Aufgabe2() {
            int x = 10;
            while (x >= 0)
            {
                Console.WriteLine(x);
                x -= 2;
            }
        }
        static void Aufgabe3()
        {
            Console.WriteLine("länge der schleife ein geben");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            while (eingabe >= 0)
            {
                Console.WriteLine(eingabe);
                eingabe -= 1;
            }
        }
        static void Aufgabe4()
        {
            Console.WriteLine("Wie viele Reihen sollen es sein?");
            int reihen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welches Symbol soll es sein? \n");
            string symbol = Console.ReadLine();

            for (int i = 1; i <= reihen; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void Aufgabe6() {
            string check = "";

            while(true)
            {
                Console.WriteLine("geben sie Ein Wort ein oder Ende zum beenden.");
                string eingabe = Console.ReadLine();

                if(eingabe == "Ende")
                {
                    Console.WriteLine("Das Wort lautet: {0}", check);
                    break;
                } else
                {
                    check += eingabe;
                }
            }
       }
    }
}
