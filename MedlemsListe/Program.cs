/*
Lav en console-app hvor brugeren kan indtaste navne i en liste.
Det skal også være muliggt at redigere, slette og søge i listen.
Appen skal styres ved hjælp af en menu.

Der stilles ikke krav om validering af brugerindtastninger.
Brug evt. “MedlemsListe” – eksemplet fra undervisningen.
(eksemplet finder du i “Eksemper fra undervisningen”)
*/

using System;
using System.Collections.Generic;
using System.Globalization;

namespace MedlemsListe
{
    class Program
    {
        static List<string> members = new List<string>();

        static void Main(string[] args)
        {
            string[] menu =
            {
                "Tast S for at soge i listen",
                "Tast V for at vise listen",
                "Tast T for at tilfoje til listen",
                "Tast R for at fjerne fra listen",
                "Tast Q for at afslutte programmet",
                "",
                "Vaelg fra menu"
            };

            while (true)
            {
                Console.Clear();
                foreach (string m in menu)
                {
                    Console.WriteLine(m);
                }

                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        Search();
                        break;

                    case "V":
                        ShowList();
                        break;

                    case "T":
                        AddToList();
                        break;

                    case "R":
                        Remove();
                        break;

                    case "Q":
                        Quit();
                        return;
                }

                static void Search()
                {
                    Console.Clear();

                    Console.WriteLine("Hvad vil du finde?");

                    string m = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower());
                    Console.WriteLine();

                    Console.WriteLine("Her er hvad jeg fandt");
                    Console.WriteLine(members.Find(members => members.Contains(m)));

                    Console.ReadLine();
                }

                static void ShowList()
                {
                    Console.Clear();

                    Console.WriteLine("Her er listen");
                    Console.WriteLine();

                    if (members.Count == 0)
                    {
                        Console.WriteLine("Listen er tom");
                    }
                    else
                    {
                        foreach (string m in members)
                        {
                            Console.WriteLine(m);
                        }
                    }
                    Console.ReadLine();
                }

                static void AddToList()
                {
                    Console.Clear();

                    Console.WriteLine("Skriv et navn til listen");

                    string m = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower());
                    members.Add(m);
                }

                static void Remove()
                {
                    Console.Clear();

                    Console.WriteLine("Skriv navnet du vil fjerne");

                    string m = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower());
                    members.Remove(m);
                }

                static void Quit()
                {
                    Console.Clear();

                    Console.WriteLine("Tryk enter for at lukke programmet");
                    Console.ReadLine();
                }

            }
        }
    }
}
