using System;
using System.IO;
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
using Newtonsoft.Json;


namespace testproj
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Skapar en tom lista
        List<PersonPoints> listaPerson = new List<PersonPoints>();

        public MainWindow()
        {
            InitializeComponent();

            //Om filen finns ta ned json till list
            if (File.Exists("personpoints.json"))
            {
                string jsonString = File.ReadAllText("personpoints.json");

                listaPerson = JsonConvert.DeserializeObject<List<PersonPoints>>(jsonString);
                Resultat();
            }

        }

        /// <summary>
        /// För att ska en person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPerson(object sender, RoutedEventArgs e)
        {
            //flagga
            bool flagga = true;
            //Skapar nya objekt
            PersonPoints person = new PersonPoints();
            //Bestämmer namnet
            person.Namn = namn.Text;
            if (namn.Text != "")
            {

                //om lista är null så krachar inte programmet
                if (listaPerson != null)
                {

                    //kollar om det finns dublett
                    foreach (var P in listaPerson)
                    {
                        if (P.Namn.ToLower() == person.Namn.ToLower())
                        {
                            //Felmedelande och sätter flagga så den inte sparas
                            feedback.Text = "Person finns redan";
                            flagga = false;
                            break;
                        }
                        //Annars sparar personen
                        flagga = true;
                    }
                }
                if (flagga)
                {
                    listaPerson.Add(person);
                    SparJson();
                    //Visa resultat
                    Resultat();
                }
            }
            else
            {
                feedback.Text = "Tom input, var god ange ett värde";
            }

        }


        /// <summary>
        /// Skapar poäng till en person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSocialPoints(object sender, RoutedEventArgs e)
        {
            //Om tom input ange felmedelande
            if (namnPoints.Text != "" && points.Text != "")
            {
                foreach (var person in listaPerson)
                {
                    if (person.Namn.ToLower() == namnPoints.Text.ToLower())
                    {
                        //Adderar poäng
                        person.SocialPoints += ReadInt(points.Text);

                        //Sparar och visar resultat
                        SparJson();
                        Resultat();
                        break;
                    }
                }
            }
            else
            {
                feedback.Text = "Tom input, var god ange ett värde";
            }


        }
        /// <summary>
        /// Tar bort poäng frn en person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractSocialPoints(object sender, RoutedEventArgs e)
        {
            //Om tom input ange felmedelande
            if (namnPoints.Text != "" && points.Text != "")
            {
                foreach (var person in listaPerson)
                {
                    if (person.Namn.ToLower() == namnPoints.Text.ToLower())
                    {
                        //Subtraherrar poäng
                        person.SocialPoints -= ReadInt(points.Text);

                        //Sparar och visar resultat

                        SparJson();
                        Resultat();
                        break;
                    }
                }
            }
            else
            {
                feedback.Text = "Tom input, var god ange ett värde";
            }

        }
        /// <summary>
        /// Skapar poäng till en person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWorkingPoints(object sender, RoutedEventArgs e)
        {
            //Om tom input ange felmedelande
            if (namnPoints.Text != "" && points.Text != "")
            {
                foreach (var person in listaPerson)
                {
                    if (person.Namn.ToLower() == namnPoints.Text.ToLower())
                    {
                        //Adderar poäng

                        person.WorkingPower += ReadInt(points.Text);

                        //Sparar och visar resultat
                        SparJson();
                        Resultat();
                        break;
                    }
                }
            }
            else
            {
                feedback.Text = "Tom input, var god ange ett värde";
            }

        }
        /// <summary>
        ///  Tar bort poäng frn en person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractWorkingPoints(object sender, RoutedEventArgs e)
        {
            //Om tom input ange felmedelande
            if (namnPoints.Text != "" && points.Text != "")
            {
                //Hittar personen genom att loopa
                foreach (var person in listaPerson)
                {
                    if (person.Namn.ToLower() == namnPoints.Text.ToLower())
                    {
                        //tar bort poäng
                        person.WorkingPower -= ReadInt(points.Text);

                        //Sparar och visar resultat
                        SparJson();
                        Resultat();
                        break;
                    }
                }
            }
            else
            {
                feedback.Text = "Tom input, var god ange ett värde";
            }

        }

        /// <summary>
        /// Sparar json från list
        /// </summary>
        private void SparJson()
        {
            // Spara ned som json med formatting
            string JsonText = JsonConvert.SerializeObject(listaPerson, Formatting.Indented);
            File.WriteAllText("personpoints.json", JsonText);
        }

        /// <summary>
        /// Visar resultatet i rutan längt ned
        /// </summary>

        private void Resultat()
        {
            //Tömmer textrutan
            resultat.Text = "";
            //Om listan är null så körs inte loopen
            if (listaPerson != null)
            {
                foreach (var person in listaPerson)
                {
                    resultat.Text += "Namn: " + person.Namn + "\n" + "Social-Points: " + person.SocialPoints + "\n" + "Working-Power: " + person.WorkingPower + "\n \n";
                }
            }
        }

        /// <summary>
        /// Metoden för säkert sätt att läsa heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        int ReadInt(string tal)
        {
            int heltal;
            if (!int.TryParse(tal, out heltal))
            {
                feedback.Text = "Du skrev inte in ett heltal. Försök igen.";
            }
            return heltal;
        }
    }
}
