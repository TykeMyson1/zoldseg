

namespace Iskola13B
{
    internal class Program
    {
        static List<Tanulo> tanulok = new List<Tanulo>();
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            Feladat6();
        }

        private static void Feladat6()
        {
            using (StreamWriter sw = new StreamWriter("azonosito.txt"))
            {
                foreach (var tanulo in tanulok)
                {
                    sw.WriteLine(tanulo.DiakNeve + " " + tanulo.Azonosito());
                }
                sw.Close();
            }
        }

        private static void Feladat3()
        {
            foreach (Tanulo tanulo in tanulok)
            {
                Console.WriteLine($"Kezdési Év: {tanulo.KezdesiEv}, Osztály Betűjele: {tanulo.Osztalybetujele}, Diák Neve: {tanulo.DiakNeve}");
            }
            Console.WriteLine($"Összes tanuló száma: {tanulok.Count}");
        }

        private static void Feladat2()
        {
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream )
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();
        }
       
    }
}
