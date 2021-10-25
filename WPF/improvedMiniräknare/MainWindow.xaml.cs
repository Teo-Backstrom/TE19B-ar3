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

namespace improvedMiniräknare
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
        private void plus(object sender, RoutedEventArgs e){
            string a = tal1.Text;
            string b = tal2.Text;
            if(!double.TryParse(a)){
                resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
            }
            else
            {
                double x = double.Parse(tal1.Text);
                
                if (!double.TryParse(b))
                {
                    resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
                }
                else
                {
                    double y = double.Parse(tal2.Text);
                    double z = x + y;
                    resultat.Text = z.ToString();
                }
                
                }
                
}
        private void minus(object sender, RoutedEventArgs e){
        string a = tal1.Text;
            string b = tal2.Text;
            if(!double.TryParse(a)){
                resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
            }
            else
            {
                double x = double.Parse(tal1.Text);
                
                if (!double.TryParse(b))
                {
                    resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
                }
                else
                {
                    double y = double.Parse(tal2.Text);
                    double z = x - y;
                    resultat.Text = z.ToString();
                }
                
                }
}
        private void multi(object sender, RoutedEventArgs e){
        string a = tal1.Text;
            string b = tal2.Text;
            if(!double.TryParse(a)){
                resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
            }
            else
            {
                double x = double.Parse(tal1.Text);
                
                if (!double.TryParse(b))
                {
                    resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
                }
                else
                {
                    double y = double.Parse(tal2.Text);
                    double z = x * y;
                    resultat.Text = z.ToString();
                }
                
                }
}
        private void dela(object sender, RoutedEventArgs e){
           string a = tal1.Text;
            string b = tal2.Text;
            if(!double.TryParse(a)){
                resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
            }
            else
            {
                double x = double.Parse(tal1.Text);
                
                if (!double.TryParse(b))
                {
                    resultat.Text = "Du skrev inte in ett heltal. Försök igen.";
                }
                else
                {
                    double y = double.Parse(tal2.Text);
                    double z = x / y;
                    resultat.Text = z.ToString();
                }
                
                }
        
}
    }
}
