using System;

public class Knyga
{
    // Klases laukai
    private string pavadinimas;
    private string autorius;
    private int puslApiuSkaicius;
    private bool perskaityta;

    // Konstruktorius
    public Knyga(string pavadinimas, string autorius, int puslapiuSkaicius)
    {
        this.pavadinimas = pavadinimas;
        this.autorius = autorius;

        if (puslapiuSkaicius <= 0)
        {
            throw new ArgumentException("Puslapiu skaicius turi buti teigiamas skaicius.");
        }
        this.puslApiuSkaicius = puslapiuSkaicius;
        this.perskaityta = false; // Inicializuojame kaip neskaityta
    }

    // Funkcija perskaityti knyga
    public void PerskaitytiKnyga()
    {
        perskaityta = true;
    }

    // Funkcija gauti aprasyma
    public string GautiAprasyma()
    {
        return $"Pavadinimas: {pavadinimas}, Autorius: {autorius}, Puslapiu skaicius: {puslApiuSkaicius}, Perskaityta: {perskaityta}";
    }
}