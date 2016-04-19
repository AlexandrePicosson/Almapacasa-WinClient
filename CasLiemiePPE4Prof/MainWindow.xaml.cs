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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace CasLiemiePPE4
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            chargedgv();
            //essai();

            
            
        }

        public void chargedgv()
        {
           // dataGrid1.ItemsSource = 

            dataGrid1.ItemsSource = controleur.getModele().getDSSoin();
            DGSemaine.ItemsSource = controleur.getModele().getDSVisite();
            DGJour.ItemsSource = controleur.getModele().getDSVisiteJour();
           // dataGrid1.ItemsSource = controleur.getModele().getDSLogin();

        
                
        }

        private void essaiVisite(object sender, RoutedEventArgs e)
        {
           // Redirection vers l'onglet Visite !
            Visite.Visibility = Visibility.Visible;
            onglets.SelectedItem = onglets.Items[4];
        
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnExporter_Click(object sender, RoutedEventArgs e)
        {
            Program.BDDLocale();
        }

       /* public void essai()
        {
            DateTime localDate = DateTime.Now;
            string date;
            date = localDate.DayOfWeek.ToString();

            string lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche;
            DateTime lundi1, mardi1, mercredi1, jeudi1, vendredi1, samedi1, dimanche1;
            switch (date)
            {
                default:
             
                    lundi = "2016-03-28";
                      
                    dimanche = "2016-03-31";

                    controleur.getModele().importSemaine(lundi, dimanche);
                    DGSemaine.ItemsSource = controleur.getModele().getDSVisite();
                    break;

                case "Wednesday":
                    //calendar1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddDays(1), DateTime.MaxValue));
                    textBox1.Text = Convert.ToString(DateTime.Now.AddDays(-3));
                    lundi1 = DateTime.Now.AddDays(-2);
                    lundi = Program.convertDate(lundi1);
                    mardi1 = DateTime.Now.AddDays(-1);
                    mardi = Program.convertDate(mardi1);
                    mercredi1 = DateTime.Now.AddDays(0);
                    mercredi = Program.convertDate(mercredi1);
                    jeudi1 = DateTime.Now.AddDays(1);
                    jeudi = Program.convertDate(jeudi1);
                    textBox1.Text = jeudi;
                    vendredi1 = DateTime.Now.AddDays(2);
                    vendredi = Program.convertDate(vendredi1);
                    samedi1 = DateTime.Now.AddDays(3);
                    samedi = Program.convertDate(samedi1);
                    dimanche1 = DateTime.Now.AddDays(4);
                    dimanche = Program.convertDate(dimanche1);



                    controleur.getModele().importSemaine(lundi, dimanche);
                    DGSemaine.ItemsSource = controleur.getModele().getDSVisite();

                    break;
                case "Thursday":
                    // calendar1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddDays(-1), DateTime.MinValue));
                    textBox1.Text = Convert.ToString(DateTime.Now.AddDays(-3));
                    lundi1 = DateTime.Now.AddDays(-3);
                    lundi = Program.convertDate(lundi1);
                    mardi1 = DateTime.Now.AddDays(-2);
                    mardi = Program.convertDate(mardi1);
                    mercredi1 = DateTime.Now.AddDays(-1);
                    mercredi = Program.convertDate(mercredi1);
                    jeudi1 = DateTime.Now.AddDays(0);
                    jeudi = Program.convertDate(jeudi1);
                    textBox1.Text = jeudi;
                    vendredi1 = DateTime.Now.AddDays(1);
                    vendredi = Program.convertDate(vendredi1);
                    samedi1 = DateTime.Now.AddDays(2);
                    samedi = Program.convertDate(samedi1);
                    dimanche1 = DateTime.Now.AddDays(3);
                    dimanche = Program.convertDate(dimanche1);



                    break;
            }
        }

           /* calendar1.BlackoutDates.Add(new CalendarDateRange(new DateTime(2016, 3, 23)));
            DateTime localDate = DateTime.Now;
            string date;
            date = localDate.DayOfWeek.ToString();
            //date = localDate.ToShortDateString();
            textBox1.Text = date;

            string lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche;
            DateTime lundi1, mardi1, mercredi1, jeudi1, vendredi1, samedi1, dimanche1;
            switch (date)
            {
                default:
                   lundi = "";
                   mardi = "";
                   break;

                case "Wednesday":
                    //calendar1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddDays(1), DateTime.MaxValue));
                    textBox1.Text =Convert.ToString(DateTime.Now.AddDays(-3));
                    lundi1 = DateTime.Now.AddDays(-2);
                    lundi = Program.convertDate(lundi1);
                    mardi1 = DateTime.Now.AddDays(-1);
                    mardi = Program.convertDate(mardi1);
                    mercredi1 = DateTime.Now.AddDays(0);
                    mercredi = Program.convertDate(mercredi1);
                    jeudi1 = DateTime.Now.AddDays(1);
                    jeudi = Program.convertDate(jeudi1);
                    textBox1.Text = jeudi;
                    vendredi1 =  DateTime.Now.AddDays(2);
                    vendredi = Program.convertDate(vendredi1);
                    samedi1 = DateTime.Now.AddDays(3);
                    samedi = Program.convertDate(samedi1);
                    dimanche1 = DateTime.Now.AddDays(4);
                    dimanche = Program.convertDate(dimanche1);



                    controleur.getModele().importSemaine(lundi, mardi);
                    dataGrid2.ItemsSource = controleur.getModele().getDSVisite();

                    break;
                case "Thursday":
                   // calendar1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddDays(-1), DateTime.MinValue));
                    textBox1.Text =Convert.ToString(DateTime.Now.AddDays(-3));
                    lundi1 = DateTime.Now.AddDays(-3);
                    lundi = Program.convertDate(lundi1);
                    mardi1 = DateTime.Now.AddDays(-2);
                    mardi = Program.convertDate(mardi1);
                    mercredi1 = DateTime.Now.AddDays(-1);
                    mercredi = Program.convertDate(mercredi1);
                    jeudi1 = DateTime.Now.AddDays(0);
                    jeudi = Program.convertDate(jeudi1);
                    textBox1.Text = jeudi;
                    vendredi1 =  DateTime.Now.AddDays(1);
                    vendredi = Program.convertDate(vendredi1);
                    samedi1 = DateTime.Now.AddDays(2);
                    samedi = Program.convertDate(samedi1);
                    dimanche1 = DateTime.Now.AddDays(3);
                    dimanche = Program.convertDate(dimanche1);

                      

                    break;
            }
            
         
        }*/

        private void SelectionDate(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            // ... See if a date is selected.
           // if (calendar.SelectedDate.HasValue)
            //{
                DateTime dateClic = calendar.SelectedDate.Value;
                string jour ;
                System.Windows.MessageBox.Show(Convert.ToString(dateClic));
                //controleur.getModele().getDSVisite().Select("datevisite BETWEEN '2016-03-28' AND '2016-03-31'");
            //}


            
         
            jour = dateClic.DayOfWeek.ToString();
             System.Windows.MessageBox.Show(jour);

             string lundi, dimanche, day;
             DateTime lundi1, dimanche1, day1;
            DGSemaine.ItemsSource = controleur.getModele().getDSVisite();
            DGJour.ItemsSource = controleur.getModele().getDSVisiteJour();
            // DGSemaine.DataContext = controleur.getModele().getDataSetVisite2().Tables[1];
             DataView dv = controleur.getModele().getDSVisite();
             DataView dve = controleur.getModele().getDSVisiteJour();
            switch (jour)
            {
                case "Monday":
                    lundi1 = dateClic.AddDays(0);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(6);
                    dimanche = Program.convertDate(dimanche1);

                    //controleur.getModele().importSemaine(lundi, dimanche, lundi);
                    
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;
                    int i = 1;
                 


                        dve.RowFilter = "datevisite = '" + Convert.ToString(lundi1) + "'";
                        DGJour.ItemsSource = dve;
                    

                    break;

                case "Tuesday":
                    lundi1 = dateClic.AddDays(-1);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(5);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);
                  
                   // controleur.getModele().importSemaine(lundi, dimanche, day);
                  //  DataView dv = controleur.getModele().getDSVisite();
                   
        
                    dv.RowFilter = "datevisite >= '" + lundi + "' AND datevisite <= '" + dimanche + "'";
                    DGSemaine.ItemsSource = dv;
                  
                   
                   // DataView dve = controleur.getModele().getDSVisiteJour();
                   dve.RowFilter = "datevisite = '" + day + "'";
                    DGJour.ItemsSource = dve; 
                    
                    break;

                case "Wednesday":
                    lundi1 = dateClic.AddDays(-2);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(4);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                 //   controleur.getModele().importSemaine(lundi, dimanche, day);
                 //   DataView dv = controleur.getModele().getDSVisite();
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;

                   
                 //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Thursday":
                    lundi1 = dateClic.AddDays(-3);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(3);
                    dimanche = Program.convertDate(dimanche1);
                     day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                 //   controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Friday":
                    lundi1 = dateClic.AddDays(-4);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(2);
                    dimanche = Program.convertDate(dimanche1);
                     day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                //    controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Saturday":
                    lundi1 = dateClic.AddDays(-5);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(1);
                    dimanche = Program.convertDate(dimanche1);
                      day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                 //   controleur.getModele().importSemaine(lundi, dimanche, day);

                    //   DataView dv = controleur.getModele().getDSVisite();
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;
                    break;
                case "Sunday":
                    lundi1 = dateClic.AddDays(-6);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(0);
                    dimanche = Program.convertDate(dimanche1);
                      day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                 //   controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                    dv.RowFilter = "datevisite >= '" + Convert.ToString(lundi1) + "' AND datevisite <= '" + Convert.ToString(dimanche1) + "'";
                    DGSemaine.ItemsSource = dv;


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(dimanche1) + "'";
                    DGJour.ItemsSource = dve;
                    break;
            }

            switch (jour)
            {
                case "Monday":
                    lundi1 = dateClic.AddDays(0);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(6);
                    dimanche = Program.convertDate(dimanche1);

                    //controleur.getModele().importSemaine(lundi, dimanche, lundi);

                   


                    dve.RowFilter = "datevisite = '" + Convert.ToString(lundi1) + "'";
                    DGJour.ItemsSource = dve;


                    break;

                case "Tuesday":
                    lundi1 = dateClic.AddDays(-1);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(5);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    // controleur.getModele().importSemaine(lundi, dimanche, day);
                    //  DataView dv = controleur.getModele().getDSVisite();



                    // DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + day + "'";
                    DGJour.ItemsSource = dve;

                    break;

                case "Wednesday":
                    lundi1 = dateClic.AddDays(-2);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(4);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    //   controleur.getModele().importSemaine(lundi, dimanche, day);
                 

                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Thursday":
                    lundi1 = dateClic.AddDays(-3);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(3);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    //   controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                  


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Friday":
                    lundi1 = dateClic.AddDays(-4);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(2);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    //    controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                   


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;

                    break;
                case "Saturday":
                    lundi1 = dateClic.AddDays(-5);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(1);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    //   controleur.getModele().importSemaine(lundi, dimanche, day);

                    //   DataView dv = controleur.getModele().getDSVisite();
                  


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(day1) + "'";
                    DGJour.ItemsSource = dve;
                    break;
                case "Sunday":
                    lundi1 = dateClic.AddDays(-6);
                    lundi = Program.convertDate(lundi1);
                    dimanche1 = dateClic.AddDays(0);
                    dimanche = Program.convertDate(dimanche1);
                    day1 = dateClic.AddDays(0);
                    day = Program.convertDate(day1);

                    //   controleur.getModele().importSemaine(lundi, dimanche, day);
                    //   DataView dv = controleur.getModele().getDSVisite();
                   


                    //   DataView dve = controleur.getModele().getDSVisiteJour();
                    dve.RowFilter = "datevisite = '" + Convert.ToString(dimanche1) + "'";
                    DGJour.ItemsSource = dve;
                    break;
            }
        }

       
        private void DGSemaine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Redirection vers l'onglet Visite !
            Visite.Visibility = Visibility.Visible;
            onglets.SelectedItem = onglets.Items[4];

            var cellInfo = DGSemaine.SelectedCells[0];
            var cellInfo2 = DGSemaine.SelectedCells[1];
            var contentPatient = cellInfo.Column.GetCellContent(cellInfo.Item);
            var contentPatient2 = cellInfo2.Column.GetCellContent(cellInfo2.Item);
            lblPatientVisite.Content = "Rendez-vous concernant : " + ((TextBlock)contentPatient).Text + " " + ((TextBlock)contentPatient2).Text;

            var cellInfo3 = DGSemaine.SelectedCells[2];
            var contentDate = cellInfo3.Column.GetCellContent(cellInfo3.Item);
            lblDateVisite.Content = "Rendez-vous du : " + ((TextBlock)contentDate).Text;

            System.Windows.MessageBox.Show(((TextBlock)contentPatient).Text);
        
        }

        private void DGJour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = DGJour.SelectedCells[0];
            var content = cellInfo.Column.GetCellContent(cellInfo.Item);
            System.Windows.MessageBox.Show(((TextBlock)content).Text);
        }

      

      
       
      
    }
}
