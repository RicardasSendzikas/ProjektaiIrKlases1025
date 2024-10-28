using System;

class Program
{
    static void Main(string[] args)
    {
        // Paprasome vartotojo ivesti knygos duomenis
        Console.Write("Iveskite knygos pavadinima: ");
        string pavadinimas = Console.ReadLine();

        Console.Write("Iveskite knygos autoriu: ");
        string autorius = Console.ReadLine();

        Console.Write("Iveskite puslapiu skaiciu: ");
        int puslapiuSkaicius;
        while (!int.TryParse(Console.ReadLine(), out puslapiuSkaicius) || puslapiuSkaicius <= 0)
        {
            Console.Write("Neteisingas puslapių skaicius. Prasome ivesti teigiama skaiciu: ");
        }

        // Sukuriame Knyga objekta
        Knyga knyga = new Knyga(pavadinimas, autorius, puslapiuSkaicius);

        // Isvedame knygos aprasyma
        Console.WriteLine("\nKnygos aprasymas:");
        Console.WriteLine(knyga.GautiAprasyma());

        // Paprasome vartotojo, ar perskaityti knyga
        Console.Write("Ar perskaityti sia knyga? (taip/ne): ");
        string pasirinkimas = Console.ReadLine().ToLower();

        if (pasirinkimas == "taip")
        {
            knyga.PerskaitytiKnyga();
            Console.WriteLine("Knyga pazymeta kaip perskaityta.");
        }

        // Isvedame atnaujinta knygos aprasyma
        Console.WriteLine("\nAtnaujintas knygos aprasymas:");
        Console.WriteLine(knyga.GautiAprasyma());
    }
}