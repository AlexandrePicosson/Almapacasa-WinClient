using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
//using System.Windows.Forms;


namespace CasLiemiePPE4
{
    public class modele
    {
        private MySqlConnection myConnection;
        private bool connOpen = false;
        private bool errGrave = false;
        private bool chargement = false;

        private MySqlDataAdapter mySqlDataAdapterPPE4 = new MySqlDataAdapter();
        private MySqlDataAdapter mySqlDataAdapterPPE4Login = new MySqlDataAdapter();
        private MySqlDataAdapter mySqlDataAdapterPPE4Visite = new MySqlDataAdapter();
       


        private DataSet datasetPPE4 = new DataSet();
        private DataSet datasetPPE4Login = new DataSet();
        private DataSet datasetPPE4Visite = new DataSet();
      


        private DataView DSInfirmiere = new DataView();
        private DataView DSSoin = new DataView();
        private DataView DSLogin = new DataView();
        private DataView DSVisite = new DataView();
        private DataView DSVisiteJour = new DataView();



        public DataView getDSInfirmiere()
        {
            return DSInfirmiere;
        }

        public DataView getDSSoin()
        {
            return DSSoin;
        }

        public DataView getDSVisite()
        {
            return DSVisite;
        }

        public DataView getDSVisiteJour()
        {
            return DSVisiteJour;
        }

        public DataView getDSLogin()
        {
            return DSLogin;
        }

        public DataSet getDataSetVisite()
        {
            return datasetPPE4Visite;
        }

        public DataSet getDataSetVisite2()
        {
            return datasetPPE4;
        }

      

        //Se connecter à la base de données
        public void seConnecter()
        {
            string myConnectionString = "Database=almapacasa;Server=localhost;User Id=root;Password=";
            myConnection = new MySqlConnection(myConnectionString);
            try
            {
                myConnection.Open();
                connOpen = true;
                System.Windows.MessageBox.Show("Belle gosseeeeeeeeeeee");
            }
            catch (Exception err)
            {
               // System.Windows.MessageBox.Show("Erreur ouverture BDD : " + err + "PBS connection");
                connOpen = false; errGrave = true;
            }
        }

        public void seDeconnecter()
        {
            if (!connOpen)
            {
                return;
            }
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connOpen = false;
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show("Erreur fermeture BDD : " + err + "PBS connection");
                errGrave = true;
            }
        }

        public void import(string log)
        {
            string req = "SELECT * FROM SOIN; SELECT P.nom, P.prenom, datevisite, heuredebut, heurefin, id_1 FROM VISITE V, INFIRMIERE I, PATIENT P WHERE I.id = V.id_1 AND P.id_her_1 = V.id_her_1  AND I.login = '" + log + "' ; ";
           // System.Windows.MessageBox.Show(log);
            if (!connOpen)
            {
                return;
            }
            mySqlDataAdapterPPE4.SelectCommand = new MySqlCommand(req, myConnection);
            try
            {
                datasetPPE4.Clear();
                mySqlDataAdapterPPE4.Fill(datasetPPE4);

                DSSoin = datasetPPE4.Tables[0].DefaultView;
                DSVisite = datasetPPE4.Tables[1].DefaultView;
                DSVisiteJour = datasetPPE4.Tables[1].DefaultView;
                chargement = true;

            }
            catch (Exception err)
            {
               // System.Windows.MessageBox.Show("Erreur chargement dataset : " + err + "PBS soin");
                errGrave = true;
            }
        }

        //vérification du log dans la BDD
        public bool logOkOuNon(string nom, string mdp)
        {
            string requete = "SELECT id FROM INFIRMIERE WHERE login = '" + nom + "' AND mdp = '" + mdp +"' ;";
            mySqlDataAdapterPPE4Login.SelectCommand = new MySqlCommand(requete, myConnection);
            //mySqlDataAdapterPPE4Login.SelectCommand = new MySqlCommand(requete, myConnection);
            
            try
            {
                datasetPPE4Login.Clear();
                mySqlDataAdapterPPE4Login.Fill(datasetPPE4Login);

                DSLogin = datasetPPE4Login.Tables[0].DefaultView;
                string ttt = Convert.ToString( DSLogin.Count);
                if (DSLogin.Count != 1)
                {
                    chargement = false;
                }
                else
                {
                    chargement = true;
                    System.Windows.MessageBox.Show("log ok");
                    import(nom);
                  
                    //faire l'import
                   

                   
                }
             
                
            }
            catch (Exception err)
            {
                //System.Windows.MessageBox.Show("log pas ok");
                errGrave = true;
                chargement = false;
            }
            return chargement;
        }

       


        public void importSemaine(string dateMin, string dateMax, string date)
        {
            if (!connOpen)
            {
                return;
            }
            string req = "SELECT nom, prenom, dateVisite, heureDebut, heureFin FROM VISITE V, PATIENT P WHERE P.id_her_1 = V.id_her_1 AND DATEVISITE BETWEEN '" + dateMin + "' AND '" + dateMax + "' ;SELECT nom, prenom, dateVisite, heureDebut, heureFin FROM VISITE V, PATIENT P WHERE P.id_her_1 = V.id_her_1 AND DATEVISITE = '" + date + "' ;";
            
          //  string req = "SELECT id_her_1 AS idPatient, dateVisite, heureDebut, heureFin FROM VISITE WHERE DATEVISITE BETWEEN '" + dateMin + "' AND '" + dateMax + "' ; SELECT id_her_1 AS idPatient, dateVisite, heureDebut, heureFin FROM VISITE WHERE DATEVISITE = '" + date + "' ;";
            mySqlDataAdapterPPE4Visite.SelectCommand = new MySqlCommand(req, myConnection);
            try
            {
                datasetPPE4Visite.Clear();
                mySqlDataAdapterPPE4Visite.Fill(datasetPPE4Visite);

                DSVisite = datasetPPE4Visite.Tables[0].DefaultView;
                DSVisiteJour = datasetPPE4Visite.Tables[1].DefaultView;
                chargement = true;



                string ttt = Convert.ToString(DSVisite.Count);
                if (DSVisite.Count == 0)
                {
                    System.Windows.MessageBox.Show("Vous n'avez pas de visites prévues cette semaine ci.");
                }
                else
                {
                    string err = Convert.ToString(DSVisite.Count);
                }

            }
            catch (Exception err)
            {
                // System.Windows.MessageBox.Show("Erreur chargement dataset : " + err + "PBS soin");
                errGrave = true;
            }
        }
       

        //tester l'export !

        //faire l'import.. 

        

    }
}
