using FlottaApp;


List<Jarmu> kocsi = new List<Jarmu>();
int hibasSorokSzama = 0;
foreach (string sor in File.ReadLines("eredmenyek.csv"))
{
    string[] adatok= sor.Split(';');
    if (adatok.Length != 4)
    {
        hibasSorokSzama++;
        continue;
    }
    string Tipus = adatok[0].Trim();
    int Alapar = Alapar;
    string Rendszam = adatok[1];
    if (Tipus == "J")
    {
        List<Jarmu> jarmuvek = new List<Jarmu>();
    }
    if (Tipus == "T")
    {
        List<Teherauto> teherautok = new List<Teherauto>();
    }
    if (!int.TryParse(adatok[2], out int pontszam))
    {
        hibasSorokSzama++;
        continue;
    }
    if (string.IsNullOrWhiteSpace(Tipus) || string.IsNullOrWhiteSpace(Rendszam))
    {
        hibasSorokSzama++;
        continue;
    }
    kocsi.Add(new Jarmu(Rendszam, Alapar));
}
Console.WriteLine($"Sikeresen beolvasott jarmuvek szama: {kocsi.Count}");
Console.WriteLine($"Hibas sorok szama:{hibasSorokSzama}");
foreach (Jarmu kiir in kocsi)
{ Console.WriteLine(kiir); }