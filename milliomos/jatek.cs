using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milliomos
{
	internal class Jatek
	{
		private List<Kerdes> kerdesek;
		private List<Kerdesek> jatekKerdes;

		public Jatek(string fajlNev, string filename)
		{
			kerdesek = new List<Kerdes>();
			jatekKerdes = new List<Kerdesek>();
			sorkerdesBeolvas(fajlNev);
			jatekKerdesBeolv(filename);
		}

		private void sorkerdesBeolvas (string fajlNev)
		{
            foreach (var sor in File.ReadAllLines(fajlNev))
            {
				if (!string.IsNullOrWhiteSpace(sor)){
					kerdesek.Add(new Kerdes(sor));
				}
            }
        }

		private void jatekKerdesBeolv(string filename)
		{
            foreach (var sor in File.ReadAllLines(filename))
            {
                if (!string.IsNullOrWhiteSpace(sor))
                {
                    jatekKerdes.Add(new Kerdesek(sor));
                }
            }
        }

		public void Sorkerdes()
		{
			Random rnd = new Random();
			Random rand = new Random();
			List<Kerdes> sorkerdesek = kerdesek.FindAll(k => k.GetKategoria() == "BIOLÓGIA" || k.GetKategoria() == "FILM" || 
			k.GetKategoria() == "IRODALOM" || k.GetKategoria() == "ÉPÍTÉSZET" || k.GetKategoria() == "FÖLDRAJZ"
            || k.GetKategoria() == "SPORT" || k.GetKategoria() == "NYELV" || k.GetKategoria() == "ORSZÁGOK" || k.GetKategoria() == "OPERA"
            || k.GetKategoria() == "ÁLTALÁNOS" || k.GetKategoria() == "TÖRTÉNELEM" || k.GetKategoria() == "VALLÁS" || k.GetKategoria() == "TECHNIKA"
            || k.GetKategoria() == "KÉPZŐMŰVÉSZET" || k.GetKategoria() == "IRODALOM");

			if (sorkerdesek.Count == 0)
			{
                Console.WriteLine("Nincs elérhető sorkérdés");
				return;
			}

			int index = rnd.Next(sorkerdesek.Count);
			Kerdes kivalsztott = sorkerdesek[index];

            Console.WriteLine("Kategória: " + kivalsztott.GetKategoria());
            Console.WriteLine(kivalsztott.GetKerdes());
            Console.WriteLine("A: " + kivalsztott.GetValasz(0));
            Console.WriteLine("B: " + kivalsztott.GetValasz(1));
            Console.WriteLine("C: " + kivalsztott.GetValasz(2));
            Console.WriteLine("D: " + kivalsztott.GetValasz(3));

            Console.Write("Sorrend: ");
			string valasz = Console.ReadLine().ToUpper();

			if (valasz == kivalsztott.GetMegoldas())
			{
                Console.WriteLine("Helyes válasz!");
				List<Kerdesek> jatek = jatekKerdes.FindAll(j => j.Kategoria() == "1");
				if (jatek.Count == 0)
				{
                    Console.WriteLine("Nincs elérhető kérdés");
					return;
				}
				int index1 = rand.Next(jatek.Count);
				Kerdesek kerdes1 = jatek[index1];
                Console.WriteLine("1000ft-os kérdés: " + kerdes1.Kerdes());
                Console.WriteLine("A: " + kerdes1.Valaszok(0));
                Console.WriteLine("B: " + kerdes1.Valaszok(1));
                Console.WriteLine("C: " + kerdes1.Valaszok(2));
                Console.WriteLine("D: " + kerdes1.Valaszok(3));

                Console.Write("Válsz: ");
				string valasz1 = Console.ReadLine().ToUpper();
				if (valasz1 == kerdes1.Helyesvalsz())
				{
                    Console.WriteLine("Nyertél 1000 forintot");
				}
				else
				{
                    Console.WriteLine("Sajnos kiestél");
				}
            }
			else
			{
                Console.WriteLine("Rossz válsz, a helyes sorrend: " + kivalsztott.GetMegoldas());
			}
        }
	}
}
