using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Jarmu
    {
        public string Rendszam { get; set; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value <= 0)
                { 
                    alapar=1000000;
                }
                alapar = value;
            }
        }

        private static int osszesJarmuSzama = 0;
        public static int OsszesJarmuSzama
        {
            get { return osszesJarmuSzama; }
        }

        public Jarmu(string Rendszam,int alapar)
        {
            Rendszam = Rendszam;
            Alapar = alapar;
        }
        public virtual int Adokalkulacio(int Ado) 
        {
            return alapar* 0.5;
        }
        public override string ToString()
        {
            return $"Jármű {Rendszam} | Alapár: {Alapar} Ft | Adó: {Adokalkulacio()} Ft";
        }

    }
}
