using System;

public class BankoSaskaita
{
    // Klases laukai
    private string savininkoVardas;
    private string saskaitosNumeris;
    private double balansas;

    // Konstruktorius
    public BankoSaskaita(string savininkoVardas, string saskaitosNumeris)
    {
        this.savininkoVardas = savininkoVardas;
        this.saskaitosNumeris = saskaitosNumeris;
        this.balansas = 0; // Inicializuokite balansa kaip 0
    }

    // Funkcija ideti pinigu
    public void IdetiPinigus(double suma)
    {
        if (suma <= 0)
        {
            Console.WriteLine("Ideta suma turi buti teigiamas skaicius.");
            return;
        }

        balansas += suma;
        Console.WriteLine($"Ideta suma: {suma}. Naujas balansas: {balansas}");
    }

    // Funkcija nusiimti pinigu
    public void NusiimtiPinigus(double suma)
    {
        if (suma <= 0)
        {
            Console.WriteLine("Nusiimama suma turi buti teigiamas skaicius.");
            return;
        }

        if (suma > balansas)
        {
            Console.WriteLine("Nepakanka lesu saskaitoje.");
        }
        else
        {
            balansas -= suma;
            Console.WriteLine($"Nusiskaiciuota suma: {suma}. Naujas balansas: {balansas}");
        }
    }

    // Funkcija gauti informacija apie saskaita
    public string GautiInformacija()
    {
        return $"Savininkas: {savininkoVardas}, Saskaitos numeris: {saskaitosNumeris}, Balansas: {balansas}";
    }
}