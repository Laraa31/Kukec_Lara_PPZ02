using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kukec_Lara_PPZ02
{
    internal class Alkoholna
    {
        String naziv, kolicina, pakiranje;
        double cijena;
        int postotak;

        public Alkoholna(string naziv, string kolicina, string pakiranje,int postotak, double cijena)
        {
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.Pakiranje = pakiranje;
            this.Postotak = postotak;
            this.Cijena = cijena;
            
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int Postotak { get => postotak; set => postotak = value; }

        public override string ToString()
        {
            String ispis = "Alkoholno piće" + "\t Naziv pića: " + this.Naziv + "\t Količina pića: " + this.Kolicina
                + "\t Pakiranje: " + this.Pakiranje + "\t Postotak: "+ this.Postotak+"% \t Cijena: " + this.Cijena + " Kn";

            return ispis;
        }
    }
}
