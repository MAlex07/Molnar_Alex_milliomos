using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milliomos
{
	internal class Kerdes
    {
		private string kerdes;
		List<string> valaszok;
		string megoldasKodja;
		string kategoria;

        public Kerdes(string kerdes, List<string> valaszok, string megoldasKodja, string kategoria)
        {
            this.kerdes = kerdes;
            this.valaszok = valaszok;
            this.megoldasKodja = megoldasKodja;
            this.kategoria = kategoria;
        }

        public Kerdes(string sor)
        {
            var elemek = sor.Split(';');
            kerdes = elemek[0];
            valaszok = new List<string> { elemek[1], elemek[2], elemek[3], elemek[4] };
            megoldasKodja = elemek[5];
            kategoria = elemek[6];
        }

        public void Kiiras()
        {
            Console.WriteLine(kategoria);
            Console.WriteLine(kerdes);
            Console.WriteLine("A: " + valaszok[0]);
            Console.WriteLine("B: " + valaszok[1]);
            Console.WriteLine("C: " + valaszok[2]);
            Console.WriteLine("D: " + valaszok[3]);
            Console.WriteLine("Megoldas kódja: " + megoldasKodja);
            Console.WriteLine("-----------------------------");
        }
    }
	}

