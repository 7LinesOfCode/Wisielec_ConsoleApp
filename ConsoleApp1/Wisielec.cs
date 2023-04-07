using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ConsoleApp1
{
     public class Wisielec
    {
        private bool wygrana;
        private  int Mistakes = 0;
        private string Haslo = "";
        private int wynik = 0;
        private List<char> WpisaneLitery = new List<char>();

        public void Start()
        {
            WczytajHaslo();
            while (Mistakes < 6)
               {
                WyswietlSzkielet();
                WyswietlHaslo();
                WczytajLitere();
                CzyWygrana();
                if (wygrana)
                     {

                        break;
                    }
                    
               }
            WyswietlSzkielet();
            WyswietlHaslo();

            if (wygrana)
                Wygrana();
            else
                Przegrana();
            

        }     /// Logic of game


        public void Wygrana()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wygrana! Hasłem było: {Haslo}");
            Console.ResetColor();
            Console.ReadKey();
        }
        private void Przegrana()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nie udało się! Hasłem było: {Haslo}");
            Console.ResetColor();
            Console.ReadKey();
        }
        private void WyswietlSzkielet()
        {
            Console.Clear();
            Console.WriteLine($"Pozostałe próby: {6-Mistakes}");
            if (Mistakes == 0)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");

            }
            else if(Mistakes == 1)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
            else if (Mistakes == 2)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |    /   ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
            else if (Mistakes == 3)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |     V   ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
            else if (Mistakes == 4)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |     V   ");
                Console.WriteLine(" |     |   ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
            else if (Mistakes == 5)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |     V   ");
                Console.WriteLine(" |     |   ");
                Console.WriteLine(" |    /   ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
            else if (Mistakes ==6)
            {
                Console.WriteLine();
                Console.WriteLine(" _______  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     O  ");
                Console.WriteLine(" |     V   ");
                Console.WriteLine(" |     |   ");
                Console.WriteLine(" |     Ʌ  ");
                Console.WriteLine(" |        ");
                Console.WriteLine("---       ");
            }
        }

        private void WczytajLitere()
        {
            Console.WriteLine();
            Console.Write("Wprowadz literę: ");
            string c = Console.ReadLine();


            if (!Haslo.Contains(c.ToUpper()))
                Mistakes++;


            c = c.ToUpper();
            

            foreach (char t in Haslo)
            {
                if ((t == Convert.ToChar(c))&&(!WpisaneLitery.Contains(Convert.ToChar(c))))
                    wynik++;
            }


            if (WpisaneLitery.Contains(Convert.ToChar(c.ToUpper())))
            {
            }
            else
                WpisaneLitery.Add(Convert.ToChar(c.ToUpper()));


        }

        private void WyswietlHaslo()
        {

            Console.WriteLine();
            Console.Write("   Hasło:  ");
            foreach (var c in Haslo)
            {
                if (c == ' ')
                    Console.Write(" ");

                //// funkcja z sprawdzaniem czy juz bylo odgadnione 
                ///
                if (WpisaneLitery.Contains(c))
                    Console.Write(c);
                else
                    Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Juz wpisane litery:");
            foreach (var c in WpisaneLitery)
            {
                Console.Write(c);
                Console.Write(",");
            }

            
        }

        private void WczytajHaslo()
        {
            Console.Write("Wprowadz hasło: ");

            string haslo = Console.ReadLine();

            Haslo = haslo.Trim().ToUpper();
            Console.Clear();
        }

        private void CzyWygrana()
        {
            if ((wynik == Haslo.Length) && (Mistakes != 6))
                wygrana = true;
        }
    }
}
