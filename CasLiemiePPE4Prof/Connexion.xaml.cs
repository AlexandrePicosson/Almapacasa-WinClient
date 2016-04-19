using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CasLiemiePPE4
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {

        public Connexion()
        {
            InitializeComponent();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            controleur.init();
            controleur.getModele().seConnecter();
           

            //vérifi 
            string nom = Convert.ToString(boxIdentifiant.Text);
            string mdp = Convert.ToString(boxMDP.Text);
            if (controleur.getModele().logOkOuNon(nom, mdp))
            {
                this.Hide();
               
               // System.Windows.MessageBox.Show("Holaaaa");
               // System.Windows.MessageBox.Show(nom);

                MainWindow menu = new MainWindow();
                menu.Show();
            }
            else
            {

                System.Windows.MessageBox.Show("Vérifiez votre identifiant et votre mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           // Program.BDDLocale();
            //Program.lismontruc();
        }

    }
}
