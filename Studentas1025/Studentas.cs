using System;

class Program
{
    static void Main(string[] args)
    {
        // Paprasome vartotojo ivesti studento duomenis
        Console.Write("Iveskite studento varda: ");
        string vardas = Console.ReadLine();

        Console.Write("Iveskite studento pavarde: ");
        string pavarde = Console.ReadLine();

        Console.Write("Iveskite studento amziu: ");
        int amzius;
        while (!int.TryParse(Console.ReadLine(), out amzius) || amzius <= 0)
        {
            Console.Write("Neteisingas amzius. Prasome ivesti teigiama skaiciu: ");
        }

        // Sukuriame Studentas objekta
        Studentas studentas = new Studentas(vardas, pavarde, amzius);

        // Gauti studento informacija
        studentas.GautiInformacija();

        // Prideti pazymius
        while (true)
        {
            Console.Write("Iveskite pazymi (0-10) arba 'q' nutraukti: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (double.TryParse(input, out double pazymys))
            {
                studentas.PridetiPazymi(pazymys);
            }
            else
            {
                Console.WriteLine("Neteisingas ivestas pazymys.");
            }

            // Gauti atnaujinta informacija apie studenta
            studentas.GautiInformacija();
        }

        Console.WriteLine("Programa baigta.");
    }
}
