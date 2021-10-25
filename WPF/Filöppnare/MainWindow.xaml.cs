using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Filöppnare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Öppna(object sender, RoutedEventArgs e)
        {
            //Finns lagringsfilen?
            if (File.Exists(filnamn.Text))
            {
                resultatRuta.Text = File.ReadAllText(filnamn.Text);
            }
            else
            {
                MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
            }
        }

    }


}
