using System;

public class Apskritimas
{
    // Laukas spinduliui
    private double spindulys;

    // Konstruktorius
    public Apskritimas(double spindulys)
    {
        if (spindulys <= 0)
        {
            throw new ArgumentException("Spindulys turi buti teigiamas skaicius.");
        }

        this.spindulys = spindulys;
    }

    // Funkcija skaiciuoti plota
    public double SkaiciuotiPlota()
    {
        return Math.PI * Math.Pow(spindulys, 2);
    }

    // Funkcija skaiciuoti perimetra
    public double SkaiciuotiPerimetra()
    {
        return 2 * Math.PI * spindulys;
    }
}