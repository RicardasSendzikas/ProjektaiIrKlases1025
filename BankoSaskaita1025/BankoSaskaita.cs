using System;

class Program
{
    static void Main(string[] args)
    {
        // Paprasome vartotojo ivesti savininko varda ir saskaitos numeri
        Console.Write("Iveskite savininko vardą: ");
        string savininkoVardas = Console.ReadLine();

        Console.Write("Iveskite sąskaitos numeri: ");
        string saskaitosNumeris = Console.ReadLine();

        // Sukuriame BankoSaskaita objektą
        BankoSaskaita saskaita = new BankoSaskaita(savininkoVardas, saskaitosNumeris);

        // Įdėti pinigus
        Console.Write("Iveskite suma, kuria norite ideti: ");
        double idetiSuma;
        double.TryParse(Console.ReadLine(), out idetiSuma);
        saskaita.IdetiPinigus(idetiSuma);

        // Nusiimti pinigus
        Console.Write("Iveskite suma, kuria norite nusiimti: ");
        double nusiimtiSuma;
        double.TryParse(Console.ReadLine(), out nusiimtiSuma);
        saskaita.NusiimtiPinigus(nusiimtiSuma);

        // Išvedame sąskaitos informaciją
        Console.WriteLine("\nSaskaitos informacija:");
        Console.WriteLine(saskaita.GautiInformacija());
    }
}