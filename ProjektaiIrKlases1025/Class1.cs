class Program
{
    static void Main(string[] args)
    {
        // Sukuriame Automobilis objekta
        Automobilis automobilis = new Automobilis("Toyota", "Corolla", 2020);

        // Gauti automobilio informacija
        automobilis.gautiInformacija();

        // Pildyti kura
        automobilis.pildytiKura(20); // Pridekite 20 litru kuro

        // Vaziuoti
        automobilis.vaziuoti(100); // Bandymas nuvaziuoti 100 km
        automobilis.vaziuoti(150); // Bandymas nuvaziuoti 150 km, jei kuro nepakaks

        // Gauti galutine informacija
        automobilis.gautiInformacija();
    }
}