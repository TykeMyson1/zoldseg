using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola13B
{
    public class Tanulo
    {
        public Tanulo(int kezdesiEv, char osztalybetujele, string diakNeve)
        {
            KezdesiEv = kezdesiEv;
            Osztalybetujele = osztalybetujele;
            DiakNeve = diakNeve;
        }

        public Tanulo(string sor)
        {
            string[] sorTomb = sor.Split(';');
            KezdesiEv = int.Parse(sorTomb[0]);
            Osztalybetujele = char.Parse(sorTomb[1]);
            DiakNeve = sorTomb[2];
        }

        public string Azonosito()
        {
            string jelszo = string.Empty;
            jelszo = (KezdesiEv % 10).ToString();
            jelszo+=Osztalybetujele.ToString();
            jelszo += DiakNeve.Split(" ")[0].Substring(0, 3).ToLower();
            jelszo += DiakNeve.Split(" ")[1].Substring(0, 3).ToLower();
            return jelszo;
        }

        public int KezdesiEv { get; private set; }
        public char Osztalybetujele { get; private set; }
        public string DiakNeve { get; private set; }

        
    }
}
