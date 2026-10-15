using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Teherauto:Jarmu
    {
        public double Teherbiras { get; set; }
        public Teherauto(double Teherbiras, string Rendszam, int alapar) : base(Rendszam, alapar)
        {
            this.Teherbiras = Teherbiras;
        }
        public override int Adokalkulacio(double Ado)
        {
            return base.Adokalkulacio(Ado)+ Teherbiras * 10000; 
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Teherbírás: [{Teherbiras}] t";
        }
    }
}
