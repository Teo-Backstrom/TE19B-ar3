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

namespace uppgift6
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
        //Deklarerar variabler
        public static double summa = 0;
        public static int counter = 0;
        public static double medelvärde = 0;
        public static string addition = "";

        private void Reset(object sender, RoutedEventArgs e)
        {
            summa = 0;
            counter = 0;
            medelvärde = 0;
            addition = "";
            Summa.Text = "";
            Medelvärde.Text = "";
            Inmatning.Text = "";
            SummaFöregående.Text = "";
        }



        private void Addera(object sender, RoutedEventArgs e)
        {
            //TryParse på inmatnings talet om fel skcika felmedelande
            double tal = 0;
            if (!double.TryParse(Inmatning.Text, out tal))
            {
                MessageBox.Show("Felaktig inmatning, Mata in ett tal");
            }
            else
            {
                //Ränkar hur många gågner man tryck på knappen för att kunnda få ett medelvärde
                counter++;

                //Få texten av hela addiditonen 
                addition += Inmatning.Text + " + ";
                //summan av alla tal som har lagts in
                summa += tal;

                //skriver ut talet i Summa boxen
                Summa.Text = addition + " = " + summa;
                SummaFöregående.Text = summa - tal + " + " + tal + " = " + summa;

                //Räkna ut medelvärde
                medelvärde = summa / counter;

                //skriv ut talet i Medelvärdeboxen
                Medelvärde.Text = summa + " / " + counter + " = " + medelvärde;
            }


        }

    }
}
