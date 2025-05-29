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

        public void Kiir()
        {
            Console.WriteLine(kategoria);
            Console.WriteLine(kerdes);
            Console.WriteLine("A: " + valaszok[0]);
            Console.WriteLine("B: " + valaszok[1]);
            Console.WriteLine("C: " + valaszok[2]);
            Console.WriteLine("D: " + valaszok[3]);
            Console.WriteLine("Helyes válasz: " + helyesValaz);
            Console.WriteLine("-------------------------------");
        }

        public string Kategoria()
        {
            return kategoria;
        }

        public string Kerdes()
        {
            return kerdes;
        }

        public string Valaszok(int index)
        {
            return valaszok[index];
        }

        public string Helyesvalsz()
        {
            return helyesValaz;
        }
    }
}
