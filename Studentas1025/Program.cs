using System;
using System.Collections.Generic;

public class Studentas
{
    // Klasės laukai
    private string vardas;
    private string pavarde;
    private int amzius;
    private List<double> pazymiai; // Laikyti pazymius
    private double vidurkis;

    // Konstruktorius
    public Studentas(string vardas, string pavarde, int amzius)
    {
        this.vardas = vardas;
        this.pavarde = pavarde;
        this.amzius = amzius;
        this.pazymiai = new List<double>(); // Inicializuojame pazymiu sarasa
        this.vidurkis = 0; // Pradiniam vidurkiui
    }

    // Funkcija pridėti pažymį
    public void PridetiPazymi(double pazymys)
    {
        if (pazymys < 0 || pazymys > 10)
        {
            Console.WriteLine("Pazymys turi buti tarp 0 ir 10.");
            return;
        }

        pazymiai.Add(pazymys);
        Console.WriteLine($"Pridetas pazymys: {pazymys}");
        AtnaujintiVidurki();
    }

    // Atnaujinti vidurki
    private void AtnaujintiVidurki()
    {
        if (pazymiai.Count == 0)
        {
            vidurkis = 0;
            return;
        }

        double suma = 0;
        foreach (var pazymys in pazymiai)
        {
            suma += pazymys;
        }
        vidurkis = suma / pazymiai.Count;
    }

    // Funkcija tikrinti, ar perejo i sekancia klase
    public bool ArPerejo()
    {
        return vidurkis >= 5;
    }

    // Funkcija gauti informacija apie studenta
    public void GautiInformacija()
    {
        Console.WriteLine($"Vardas: {vardas}, Pavarde: {pavarde}, Amzius: {amzius}, Vidurkis: {vidurkis}");
        string statusas = ArPerejo() ? "perejo i sekancia klase." : "neperejo i sekancia klase.";
        Console.WriteLine($"Studentas {statusas}");
    }
}