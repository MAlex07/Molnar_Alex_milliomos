namespace milliomos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			var sorok = File.ReadAllLines("sorkerdes.txt");
			foreach (var sor in sorok)
			{
				var k = new Kerdes(sor);
				k.Kiiras();
			}
            /*
			var jatekkerdesek = File.ReadAllLines("kerdes.txt");
			foreach (var sor in jatekkerdesek)
			{
				var jk = new Kerdesek(sor);
				jk.Kiir();
			}
			*/

            Jatek jatek = new Jatek("sorKerdes.txt");
			jatek.Sorkerdes();

            Console.WriteLine("Játék vége");
		}
	}
}
