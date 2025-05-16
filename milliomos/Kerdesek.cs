using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milliomos
{
	internal class Kerdesek
	{
        private int nehezseg;
		string kerdes;
		List<string> valaszok;
		string helyesValaz;
		string kategoria;

        public Kerdesek(int nehezseg, string kerdes, List<string> valaszok, string helyesValaz, string kategoria)
        {
            this.nehezseg = nehezseg;
            this.kerdes = kerdes;
            this.valaszok = valaszok;
            this.helyesValaz = helyesValaz;
            this.kategoria = kategoria;
        }

        public Kerdesek(string sor)
        {
            var elemek = sor.Split(';');
            nehezseg = int.Parse(elemek[0]);
            kerdes = elemek[1];
            valaszok = new List<string> { elemek[2], elemek[3], elemek[4], elemek[5] };
            helyesValaz = elemek[6];
            kategoria = elemek[7];
        }
    }
}
