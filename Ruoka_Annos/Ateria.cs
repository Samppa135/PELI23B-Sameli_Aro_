enum PääRaakaAine
{
    Liha,
    Tofu
}
enum Lisuke
{
    Peruna,
    Riisi
}
enum Kastike
{
    Pippuri,
    Soijakastike
}

class Ateria : IAteria, IAteria1
{
    // Ateria koostuu kolmesta aineksesta
    // Ne ovat private jotta niitä ei voi muuttaa aterian
    // luomisen jälkeen
    private PääRaakaAine pääaine;
    private Lisuke lisuke;
    private Kastike kastike;

    // Konstruktori määrää että uuden aterian voi luoda vain
    // jos antaa kaikki kolme ainesta
    public Ateria(PääRaakaAine pääaine, Lisuke lisuke, Kastike kastike)
    {
        // Tämän ateria olion pääaineeksi tulee parametrina
        // annettu pääaine: this. viittaa olioon
        this.pääaine = pääaine;
        this.lisuke = lisuke;
        this.kastike = kastike;
    }

    // Koska kastike on private, pitää tehdä funktio joka on public
    // jotta sen voi lukea
    public Kastike AnnaKastike()
    {
        return this.kastike;
    }

    // ToString auttaa aterian tulostamisessa.
    // Ohjelmoijan ei tarvitse muistaa mitä kaikkea ateriassa on
    // Jos/kun Ateria luokka muuttuu, tarvitsee tulostuskoodi muuttaa vain
    // tässä funktiossa
    public override string ToString()
    {
        return $"Pääraaka-aine: {pääaine}, lisuke: {lisuke}, kastike: {kastike}";
    }
    static void Main(string[] args)
{
    // Luo muuttujat eri aineksille ja anna niille oletusarvot
    PääRaakaAine valittuPääAine = PääRaakaAine.Tofu;
    Lisuke valittuLisuke = Lisuke.Riisi;
    Kastike valittuKastike = Kastike.Soijakastike;

    // Kysy käyttäjältä mitkä ainekset ateriaan laitetaan
    // ...

    // Luo ateria joka sisältää valitut ainekset
    Ateria tilaus = new Ateria(valittuPääAine, valittuLisuke, valittuKastike);

    // Tulosta ateria. Tämä kutsuu automaattisesti tilaus.ToString() funktiota
    Console.WriteLine(tilaus);
}
}


