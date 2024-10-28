using System;

class Program
{
    static void Main(string[] args)
    {
        // Paprasome vartotojo ivesti spinduli
        Console.Write("Iveskite apskritimo spinduli: ");
        double spindulys;
        while (!double.TryParse(Console.ReadLine(), out spindulys) || spindulys <= 0)
        {
            Console.Write("Neteisingas spindulys. Prasome ivesti teigiama skaiciu: ");
        }

        // Sukuriame Apskritimas objekta
        Apskritimas apskritimas = new Apskritimas(spindulys);

        // Apskaiciuoti plota ir perimetra
        double plotas = apskritimas.SkaiciuotiPlota();
        double perimetras = apskritimas.SkaiciuotiPerimetra();

        // Išvedame rezultatus
        Console.WriteLine($"Apskritimo plotas: {plotas:F2}");
        Console.WriteLine($"Apskritimo perimetras: {perimetras:F2}");
    }
}