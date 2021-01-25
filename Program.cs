using System;
using System.Collections.Generic;

namespace Sarcastic8ball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>();
            answers.Add("Zou je da wel doen?");
            answers.Add("Sure, do whatever.");
            answers.Add("Pfffffff...");
            answers.Add("Vraag het aan uw ma.");
            answers.Add("Wa ben ik? Uw moeder?");
            answers.Add("Zeg jong, met al uw dwaze vragen...");
            answers.Add("Ja, maar voorzichtig he.");
            answers.Add("Jeez, buy a girl a drink first.");
            answers.Add("Ja ja, doe maar.");
            answers.Add("Ik zal er eens over nadenken.");
            answers.Add("Hoe moet ik da weten?");
            answers.Add("Nee, echt, NEE!");
            answers.Add("Zoek het zelf uit.");
            answers.Add("Weet ik veel?");
            answers.Add(" ¯\\_(ツ)_/¯ ");
            answers.Add("Wablieft?");
            answers.Add("Wablieft en wablaft zitten in een boom. Wablaft valt eruit. Wie zit er dan nog in?");
            answers.Add("Hoe lang is een Chinees.");
            answers.Add("Wa vinde zelf?");
            answers.Add("Vinde da nu zelf een goeie vraag?");
            answers.Add("Ik ben bezig. Zieje da nie?");
            answers.Add("Laat mij es gerust jong.");
            answers.Add("Morgen misschien.");
            answers.Add("TETTEN!");
            answers.Add(" (.)(.) ");
            answers.Add("Waarom vraagde dat aan mij?");
            answers.Add("Moet da nu echt?");
            answers.Add("Serieus?");
            answers.Add("Baby shark do do do do do dooo...");
            answers.Add("Uw veters zijn los.");
            answers.Add("Uw spriet staat open.");
            answers.Add("Pas op! Achter u! Een priapisme!");
            answers.Add("Excuseer?");
            answers.Add("Euh...");
                        
            do
            {
                Console.Clear();
                Console.Write("Stel uw vraag: ");
                string q = Console.ReadLine();
                Console.Clear();

                Console.Write("Momentje");
                for(int i=0; i<10; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Write(".");
                }
                                
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine($"Dus, uw vraag was: {q}");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("*zucht*");
                System.Threading.Thread.Sleep(1000);
                Random r = new Random();
                int answerNr = r.Next(0, answers.Count);
                Console.WriteLine(answers[answerNr]);

                Console.WriteLine("Druk op enter om nog een vraag te stellen of sluit dit venster en ga iets nuttig doen.");
                string nothing = Console.ReadLine();
                
            }
            while (true);

        }
        
    }
}
