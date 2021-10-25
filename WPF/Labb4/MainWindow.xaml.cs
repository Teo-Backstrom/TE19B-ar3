using System;
using System.Collections.Generic;
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

namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> namnLista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            string namn = rutaNamn.Text;

            if (namn != "")
            {
                rutaLista.Text += $"{namn} \n";
                namnLista.Add(namn);

            }
            else
            {
                rutaFel.Text = "Fältet var tomt";
            }

        }
        private void ClickSpara(object sender, RoutedEventArgs e)
        {

        }
    }
}
