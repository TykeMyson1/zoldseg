

namespace BalatonCLI_felk
{
    public class Program
    {
        public static List<Telek> telkek=new List<Telek>();
        public static int a=0;
        public static int b=0;
        public static int c=0;
        static void Main(string[] args)
        {
            Beolvas();
            Feladat2();
        }

        private static void Feladat2()
        {
            Console.WriteLine($"2. feladat. A mintában {telkek.Count} telek szerepel.");
        }

        public static void Beolvas()
        {
            StreamReader sr = new StreamReader("utca.txt");

            //első sor
            string[] elsosor = sr.ReadLine().Split(' ');
            a=int.Parse(elsosor[0]);
            b=int.Parse(elsosor[1]);
            c=int.Parse(elsosor[2]);

            while (!sr.EndOfStream)
            {
                telkek.Add(new Telek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
