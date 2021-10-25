﻿using System;
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

namespace morsekod
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

        private void Sök(object sender, RoutedEventArgs e)
        {
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";
            string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                  "....", "..", ".---", "-.-", ".-..", "--", "-.",
                  "---", ".--.", "--.-", ".-.", "...", "-", ".--",
                  "...-", ".--", "-..-", "-.--", "--..", ".--.-",
                  ".-.-", "---.", " "};
            string textPåMorse = "";
            foreach (var tecken in sökTerm.Text)
            {
                // Plocka ut bokstaven som söks
                string bokstav = tecken.ToString().ToUpper();

                // Hitta index i alfabetet (-1 betyder hittades inte)
                int index = alfabetet.IndexOf(bokstav);
                if (index != -1)
                {
                    // Sätt samman meddelandet
                    textPåMorse += morse[index];
                }
            }
            resultat.Text = textPåMorse;
        }
    }
}
