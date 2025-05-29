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

		public Jatek(string fajlNev)
		{
			kerdesek = new List<Kerdes>();
			sorkerdesBeolvas(fajlNev);
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

		public void Sorkerdes()
		{
			Random rnd = new Random();
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
			}
			else
			{
                Console.WriteLine("Rossz válsz, a helyes sorrend: " + kivalsztott.GetMegoldas());
			}
        }
	}
}
