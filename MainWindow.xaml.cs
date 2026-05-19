using Iskola13B;
using System.Collections.ObjectModel;
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

namespace IskolaWPF13B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ObservableCollection<string> tanulok = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            Feladat2();
            lbxLista.ItemsSource = tanulok;
        }
        private static void Feladat2()
        {
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {

            if (lbxLista.SelectedIndex < 0)
            {
                MessageBox.Show("Nem jelölt ki tanulót!");
            }
            else
            {
                tanulok.RemoveAt(lbxLista.SelectedIndex);
            }
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("nevekNEW.txt")) 
                { 
                    foreach(var tanulo in tanulok)
                        sw.WriteLine(tanulo);
                    MessageBox.Show("Sikeres Mentés!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }
    }
}