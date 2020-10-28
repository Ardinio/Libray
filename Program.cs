using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Start : library librarys = new library();

            Console.WriteLine("Böcker som redan finns i bibiloteket");
            Console.WriteLine("Da vinci koden, Dan Brown, 2003");
            Console.WriteLine("Sagan om de två tornen, J.R.R, 2012");
            Console.WriteLine("Kampen om järntronen, Geroge R.R. Martin, 1996");
            Console.WriteLine("Harry Potter och fången från Azkaban, J.K. Rowling, 1999");
            Console.WriteLine("Mammutjägarna, Jean M. Auel, 1985");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("[A] Lägg till en book --------");
                Console.WriteLine("[V] Vissa alla böcker---------");
                Console.WriteLine("[S] Sök efter en book---------");
                Console.WriteLine("[Q] Avsluta programmet--------");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "A":
                        Console.WriteLine("Välj categori! Fantasi [F], Äventur [Ä] eller Roman [R]: Du kan gå till baka via [B]");
                        while (true)
                        {
                            string consoleinput = Console.ReadLine();
                            if (consoleinput == "F")
                            {
                                // Fantasy fantasy = new Fantasy();
                                Console.WriteLine("Kommer i nästa uppdatering.");
                                Console.ReadLine();
                                // fantasy.ToString();
                            }

                            else if (consoleinput == "Ä")
                            {
                                // Adventure adventure = new Adventure();
                                Console.WriteLine("Kommer i nästa uppdatering.");
                                Console.ReadLine();
                                // adventure.ToString();
                            }

                            else if (consoleinput == "R")
                            {
                                // Romance romance = new Romance();
                                Console.WriteLine("Kommer i nästa uppdatering.");
                                Console.ReadLine();
                                // romance.ToString();
                            }

                            else if (consoleinput == "B")
                            {
                                goto Start;
                            }

                            else
                            {
                                Console.WriteLine("Något gick fel Skriv in vilken categori du ska välja!");
                                Console.ReadLine();
                            }
                        }

                    case "V":
                        //  librarys.ShowAllBooks(librarys.ShowBooks());
                        Console.WriteLine("Kommer i ästa uppdatering");
                        Console.ReadLine();
                        break;

                    case "S":
                        //  librarys.SearchBook(Console.ReadLine());
                        Console.WriteLine("Kommer i nästa uppdatering");
                        Console.ReadLine();
                        break;

                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Något gick fel tryck på en knapp som är koplad till en funtion!");
                        break;
                }
            }
        }
    }
}