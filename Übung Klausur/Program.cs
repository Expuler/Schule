using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_Klausur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswortEingabe();
        }

        static void TypKonvertierung() // 2)
        {
            Console.WriteLine("Geben Sie die erste Zahl ein:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double numberResult = number1 * number2;

            Console.WriteLine(numberResult);
            Console.ReadKey();
        }

        static void RechnungMitModulo() // 3)
        {
            Console.WriteLine("Geben Sie eine Zahl ein:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0)
            {
                Console.WriteLine("Es ist durch 5 teilbar");
            }
            else
            {
                Console.WriteLine("Die Zahl ist nicht durch 5 teilbar");
            }
        }

        static void WhileSchleifeA() // 7) a)
        {
            while (true)
            {
                Console.WriteLine("Schreibe 'x' für Wiederholung oder etwas anderes für Fortsetzung:");
                string input = Console.ReadLine();
                if (input == "x")
                {
                    break;
                }
            }
        }

        static string WhileSchleifeB() // 7) b)
        {
            string input = "";
            while (input != "x")
            {
                Console.WriteLine("Schreibe 'x' um zu beenden:");
                input = Console.ReadLine();
            }
            return input;
        }

        static void StringZusammenfügen() // 8)
        {
            string textResult = "";

            while (true)
            {
                Console.WriteLine("Schreibe: 'Ende' zum Beenden oder 'Corona' um Nichts hinzuzufügen:");
                string text1 = Console.ReadLine();

                if (text1 == "Corona")
                {
                    continue;
                }
                else if (text1 == "Ende")
                {
                    Console.WriteLine(textResult);
                    break;
                }
                else
                {
                    textResult += text1;
                }
            }
            Console.ReadKey();
        }

        static void AlterNachschauen()
        {
            while (true)
            {
                Console.WriteLine("Bitte Alter Eingeben");
                int Alter = Convert.ToInt32(Console.ReadLine());

                if (Alter >= 5 && Alter <= 100)
                {
                    Console.WriteLine("Akzeptiert!");
                    break;
                }
            }
            Console.ReadKey();
        }

        static void PasswortEingabe()
        {
            for (int zähler = 3; zähler > 0; zähler--)
            {
                Console.WriteLine("Passwort Eingeben:");
                string pwd = Console.ReadLine();

                if (pwd == "geheim")
                {
                    Console.WriteLine("Angemeldet");
                    break;
                }
                else
                {
                    Console.WriteLine($"Falsches Passwort. Noch {zähler - 1} Versuche übrig.");
                }
            }
            Console.ReadKey();
        }
    
    }
}