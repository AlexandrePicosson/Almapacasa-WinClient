using System;
using System.Data;
using Microsoft.Win32;


namespace CasLiemiePPE4
{


    //public partial class BDDLocale {
    /*partial class VISITEDataTable
    {
        private int idVisite;
    }

    partial class SOINDataTable
    {
        private int idSoin;
    } */


    static class Program
    {
        public static void BDDLocale()
        {
            // Create two DataTable instances.
            DataTable table1 = new DataTable("visite");
            table1.Columns.Add("idVisite");
            table1.Columns.Add("dateVisite");
            table1.Columns.Add("heureDebut");
            table1.Columns.Add("heureFin");
            table1.Columns.Add("dateModif");
            table1.Rows.Add(1, "02-12-1995", "21:15:32", "21:35:24", "");
        

            DataTable table2 = new DataTable("soin");
            table2.Columns.Add("idSoin");
            table2.Columns.Add("libelle");
            table2.Columns.Add("description");
            table2.Columns.Add("dateSoin");
            table2.Columns.Add("prevu");
            table2.Columns.Add("effectue");
            table2.Rows.Add(1, "Doli", "donner doliprane", "02/12/1995", "Y", "Y");
            table2.Rows.Add(1, "enplus", "pour Alex", "02/12/1995", "Y", "Y");

            DataTable table3 = new DataTable("infirmiere");
            table3.Columns.Add("urlPhoto");
            table3.Rows.Add("urlphotoooooo");

            DataTable table4 = new DataTable("patient");
            table4.Columns.Add("idPatient");
            table4.Columns.Add("nom");
            table4.Columns.Add("prenom");
            table4.Columns.Add("login");
            table4.Columns.Add("mdp");
            table4.Columns.Add("anNaiss");
            table4.Columns.Add("sexe");
            table4.Columns.Add("rue");
            table4.Columns.Add("cp");
            table4.Columns.Add("ville");
            table4.Columns.Add("telephone");
            table4.Columns.Add("droit");
            table4.Rows.Add(1, "Giraudeau", "Samantha", "sgira", "12345678", "1995", "F", "rue du plessis gautron", "44000", "nantes", "0645691949", "tous");

            DataTable table5 = new DataTable("personneConfiance");
            table5.Columns.Add("idPersonne");
            table5.Columns.Add("nom");
            table5.Columns.Add("prenom");
            table5.Columns.Add("login");
            table5.Columns.Add("mdp");
            table5.Columns.Add("anNaiss");
            table5.Columns.Add("sexe");
            table5.Columns.Add("rue");
            table5.Columns.Add("cp");
            table5.Columns.Add("ville");
            table5.Columns.Add("telephone");
            table5.Columns.Add("droit");
            table5.Rows.Add(1, "Giraudeau", "Samantha", "confiance", "12345678", "1995", "F", "rue du plessis gautron", "44000", "nantes", "0645691949", "tous");

            DataTable table6 = new DataTable("temoignage");
            table6.Columns.Add("idTemoignage");
            table6.Columns.Add("libelle");
            table6.Rows.Add(1, "libelleeeeeeee");

            DataTable table7 = new DataTable("indisponibilite");
            table7.Columns.Add("idIndispo");
            table7.Columns.Add("dateDebut");
            table7.Columns.Add("dateFin");
            table7.Columns.Add("type");
            table7.Rows.Add(1, "02/12/1996", "12-12-1995", "malade");

            DataTable table8 = new DataTable("administrateur");
            table8.Columns.Add("idAdministrateur");
            table8.Columns.Add("nom");
            table8.Columns.Add("prenom");
            table8.Columns.Add("login");
            table8.Columns.Add("mdp");
            table8.Columns.Add("anNaiss");
            table8.Columns.Add("sexe");
            table8.Columns.Add("rue");
            table8.Columns.Add("cp");
            table8.Columns.Add("ville");
            table8.Columns.Add("telephone");
            table8.Columns.Add("droit");
            table8.Rows.Add(1, "Giraudeau", "Samantha", "admin", "12345678", "1995", "F", "rue du plessis gautron", "44000", "nantes", "0645691949", "tous");


            DataTable table9 = new DataTable("categorieSoin");
            table9.Columns.Add("idCategorie");
            table9.Columns.Add("libelle");
            table9.Columns.Add("description");
            table9.Rows.Add(1, "doliprane", "mal a la tête");

            DataTable table10 = new DataTable("commentaire");
            table10.Columns.Add("idCommentaire");
            table10.Columns.Add("libelle");
            table10.Columns.Add("dateModif");
            table10.Rows.Add(1, "limite limite", "2016-12-02");


            DataTable table11 = new DataTable("typeSoin");
            table11.Columns.Add("idSoin");
            table11.Columns.Add("libelle");
            table11.Columns.Add("description");
            table11.Columns.Add("dateTypeSoin");
            table11.Rows.Add(1, "lib", "des", "datesoin");


            // Create a DataSet and put both tables in it.
            DataSet set = new DataSet("BDD");
            set.Tables.Add(table1);
            set.Tables.Add(table2);
            set.Tables.Add(table3);
            set.Tables.Add(table4);
            set.Tables.Add(table5);
            set.Tables.Add(table6);
            set.Tables.Add(table7);
            set.Tables.Add(table8);
            set.Tables.Add(table9);
            set.Tables.Add(table10);
            set.Tables.Add(table11);
        

            // Visualize DataSet.

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "XMl files (*.xml)|*.xml|All files (*.*)|*.*";
            savefile.InitialDirectory = "C:\\Users\\Desktop\\";
            savefile.ShowDialog();
            var x = savefile.FileName;
            System.Windows.MessageBox.Show(set.GetXml());
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(x))
            {
                writer.Write(set.GetXml());
            }
        }

        public static void lismontruc()
        {
            DataSet leset = new DataSet("BDD");
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.ShowDialog();
            var x = openfile.FileName;
            leset.ReadXml(x);
            System.Windows.MessageBox.Show(leset.GetXml());
            System.Windows.MessageBox.Show(leset.Tables[1].ToString());

        }

        public static void Exporter(DataTable table1, DataTable table2, DataTable table3, DataTable table4, DataTable table5, DataTable table6, DataTable table7, DataTable table8, DataTable table9, DataTable table10, DataTable table11)
        {
            DataSet set = new DataSet("BDD");
            set.Tables.Add(table1);
            set.Tables.Add(table2);
            set.Tables.Add(table3);
            set.Tables.Add(table4);
            set.Tables.Add(table5);
            set.Tables.Add(table6);
            set.Tables.Add(table7);
            set.Tables.Add(table8);
            set.Tables.Add(table9);
            set.Tables.Add(table10);
            set.Tables.Add(table11);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "XMl files (*.xml)|*.xml|All files (*.*)|*.*";
            savefile.InitialDirectory = "C:\\Users\\Desktop\\";
            savefile.ShowDialog();
            var x = savefile.FileName;
            System.Windows.MessageBox.Show(set.GetXml());
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(x))
            {
                writer.Write(set.GetXml());
            }
        }

        public static string convertDate(DateTime date)
        {
           // return date;
            var annee = date.Year;
            string mois = Convert.ToString(date.Month);
            string jour = Convert.ToString(date.Day);
            if (mois.Length < 2)
            {
                mois = "0" + mois;
            }
            if (jour.Length < 2)
            {
                jour = "0" + jour;
            }
            string dateC = annee + "-" + mois + "-" + jour;
            return dateC;
 
        }
    }
}
//}

namespace CasLiemiePPE4 {
    
    

}
