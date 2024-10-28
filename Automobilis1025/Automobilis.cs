class Program
{
    static void Main(string[] args)
    {
        // Paprasome vartotojo ivesti automobilio duomenis
        Console.Write("Iveskite automobilio marke: ");
        string marke = Console.ReadLine();

        Console.Write("Iveskite automobilio modelį: ");
        string modelis = Console.ReadLine();

        Console.Write("Iveskite automobilio pagaminimo metus: ");
        int metai;
        while (!int.TryParse(Console.ReadLine(), out metai))
        {
            Console.Write("Neteisingi metai. Prasome ivesti skaiciu: ");
        }

        Console.Write("Iveskite pradini kuro likuti (litrais): ");
        double kuroLikutis;
        while (!double.TryParse(Console.ReadLine(), out kuroLikutis) || kuroLikutis < 0)
        {
            Console.Write("Neteisingas kuro likutis. Prasome ivesti teigiama skaiciu: ");
        }

        // Sukuriame Automobilis objekta
        Automobilis automobilis = new Automobilis(marke, modelis, metai, kuroLikutis);

        // Gauti automobilio informacija
        automobilis.gautiInformacija();

        // Paprasome vartotojo ivesti kuro papildyma
        Console.Write("Iveskite kuro papildyma (litrais): ");
        double papildymas;
        while (!double.TryParse(Console.ReadLine(), out papildymas) || papildymas < 0)
        {
            Console.Write("Neteisingas kuro papildymas. Prasome ivesti teigiama skaiciu: ");
        }

        // Pildyti kura
        automobilis.pildytiKura(papildymas);

        // Paprasome vartotojo ivesti nuvaziuota atstuma
        Console.Write("Iveskite nuvaziuota atstuma (km): ");
        double atstumas;
        while (!double.TryParse(Console.ReadLine(), out atstumas) || atstumas < 0)
        {
            Console.Write("Neteisingas atstumas. Prasome ivesti teigiama skaiciu: ");
        }

        // Apskaiciuojame kuro likuti
        automobilis.vaziuoti(atstumas);
    }
}