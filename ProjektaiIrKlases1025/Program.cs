using System;

public class Automobilis
{
    // Klases laukai
    private string marke;
    private string modelis;
    private int metai;
    private double kuroLikutis; // litrais

    // Konstruktorius, kuris nustato pradine marke, modeli ir metus
    public Automobilis(string marke, string modelis, int metai)
    {
        this.marke = marke;
        this.modelis = modelis;
        this.metai = metai;
        this.kuroLikutis = 0; // Pradinis kuro likutis
    }

    // Funkcija pildytiKura
    public void pildytiKura(double kiekis)
    {
        if (kiekis < 0)
        {
            Console.WriteLine("Kuro kiekis negali buti neigiamas.");
            return;
        }

        kuroLikutis += kiekis;
        Console.WriteLine($"Prideta {kiekis} litru kuro. Dabar kuro likutis: {kuroLikutis} litru.");
    }

    // Funkcija vaziuoti
    public void vaziuoti(double atstumas)
    {
        double sunaudotasKuras = atstumas / 10; // 1 litras kurui 10 km

        if (sunaudotasKuras > kuroLikutis)
        {
            Console.WriteLine("Nepakanka kuro, norint nuvaziuoti si atstuma.");
        }
        else
        {
            kuroLikutis -= sunaudotasKuras;
            Console.WriteLine($"Nuvaziavote {atstumas} km. Sunaudota {sunaudotasKuras} litru kuro. Kuro likutis: {kuroLikutis} litru.");
        }
    }

    // Funkcija gautiInformacija
    public void gautiInformacija()
    {
        Console.WriteLine($"Marke: {marke}, Modelis: {modelis}, Metai: {metai}, Kuro likutis: {kuroLikutis} litru.");
    }
}