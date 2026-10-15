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
