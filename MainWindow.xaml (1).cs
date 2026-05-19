using BalatonCLI_felk;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BalatonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  List<Telek> telkek = new List<Telek>();
        public  int a = 0;
        public  int b = 0;
        public  int c = 0;
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
            dtgAdatok.ItemsSource = telkek;
        }
        public  void Beolvas()
        {
            StreamReader sr = new StreamReader("utca.txt");

            //első sor
            string[] elsosor = sr.ReadLine().Split(' ');
            a = int.Parse(elsosor[0]);
            b = int.Parse(elsosor[1]);
            c = int.Parse(elsosor[2]);

            while (!sr.EndOfStream)
            {
                telkek.Add(new Telek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}