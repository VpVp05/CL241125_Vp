using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL241125_Vp
{
    internal class Auto
    {
        private List<Ember> tulajdonosok = [];
        public string Rendszam {  get; set; }
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Teljesitmeny { get; set; }
        public float Fogyasztas { get; set; }

        public void TulajokRogzitese(params string[] tulajdonosok)
        {
            foreach(var tulaj in tulajdonosok)
            {
                this.tulajdonosok.Add(new Ember(tulaj));
            }
        }

        public string TulajdonosokListaja =>
           string.Join('\n', this.tulajdonosok);

        public override string ToString() =>
            $"[{Rendszam}] {Gyarto} {Modell} ({Teljesitmeny}) hp, {Fogyasztas} l/100km";

        //DRY = Don't Repeat Yourself!

        /// <summary>
        /// részletesen meg kell adni az autó adatait
        /// </summary>
        /// <param name="rendszam">az autó rendszáma</param>
        /// <param name="gyarto">az autót gyártó cég</param>
        /// <param name="modell">az autó modell megnevezése</param>
        /// <param name="teljesitmeny">az autó teljesítménye lóerőben</param>
        /// <param name="fogyasztas">a fogyasztás l/100km-en</param>
        public Auto(string rendszam, string gyarto, string modell, int teljesitmeny, float fogyasztas)
        {
            Rendszam = rendszam;
            Gyarto = gyarto;
            Modell = modell;
            Teljesitmeny = teljesitmeny;
            Fogyasztas = fogyasztas;
        }
        /// <summary>
        /// Ez a konstruktor egy 250hp, 6.7-es fogyasztású Ford Focust fog inicializálni
        /// </summary>
        /// <param name="rendszam">Az autó rendszáma</param>
        public Auto(string rendszam) : this(rendszam, "Ford", "Focus", 250, 6.7F)
        {
            //itt még amúgy lehetne bármi egyéb
        }

        public Auto(int randomSeed)
        {
            Random rnd = new(randomSeed);
            Rendszam = $"{(char)rnd.Next(65, 91)}{(char)rnd.Next(65, 91)}{(char)rnd.Next(65, 91)}-{(char)rnd.Next(65, 91)}";

            string[] gyartok = ["Ford", "Peugeto", "Audi"];
            Gyarto = gyartok[rnd.Next(gyartok.Length)];

            string[] modell = ["Bubu", "Ruru", "Bika"];
            Modell = modell[rnd.Next(modell.Length)];

            Teljesitmeny = rnd.Next(80, 300);

            Fogyasztas = rnd.Next(50, 100) / 10F;
        }
    }
}
