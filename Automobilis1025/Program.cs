using System;

public class Automobilis
{
    // Klasės laukai
    private string marke;
    private string modelis;
    private int metai;
    private double kuroLikutis; // litrais

    // Konstruktorius
    public Automobilis(string marke, string modelis, int metai, double kuroLikutis)
    {
        this.marke = marke;
        this.modelis = modelis;
        this.metai = metai;
        this.kuroLikutis = kuroLikutis;
    }

    // Funkcija pildytiKura
    public void pildytiKura(double papildymas)
    {
        if (papildymas < 0)
        {
            Console.WriteLine("Kuro papildymas negali būti neigiamas.");
            return;
        }

        kuroLikutis += papildymas;
        Console.WriteLine($"Pridėta {papildymas} litrų kuro. Dabar kuro likutis: {kuroLikutis} litrų.");
    }

    // Funkcija vaziuoti
    public void vaziuoti(double atstumas)
    {
        double sunaudotasKuras = atstumas / 10; // 1 litras kurui 10 km

        if (sunaudotasKuras > kuroLikutis)
        {
            Console.WriteLine("Nepakanka kuro, norint nuvažiuoti šį atstumą.");
        }
        else
        {
            kuroLikutis -= sunaudotasKuras;
            Console.WriteLine($"Nuvažiavote {atstumas} km. Sunaudota {sunaudotasKuras} litrų kuro. Kuro likutis: {kuroLikutis} litrų.");
        }
    }

    // Funkcija gautiInformacija
    public void gautiInformacija()
    {
        Console.WriteLine($"Markė: {marke}, Modelis: {modelis}, Metai: {metai}, Kuro likutis: {kuroLikutis} litrų.");
    }
}