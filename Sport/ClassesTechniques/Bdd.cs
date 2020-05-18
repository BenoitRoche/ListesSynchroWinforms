using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport.ClassesTechniques
{
    class Bdd
    {
        private MySqlConnection connexion; // l'objet connexion de votre base de données
        private static Bdd instance; // l'instance de sa propre classe
        /// <summary>
        /// Constructeur
        /// </summary>
        private Bdd()
        {
            ConnectionStringSettings cnMysql = ConfigurationManager.ConnectionStrings["ConnMysqlLocal"];
            string cs = string.Format(cnMysql.ConnectionString,
                                                ConfigurationManager.AppSettings["HOSTMYSQL"],
                                                ConfigurationManager.AppSettings["PORTMYSQL"],
                                                ConfigurationManager.AppSettings["DBMYSQL"],
                                                ConfigurationManager.AppSettings["USERMYSQL"],
                                                ConfigurationManager.AppSettings["PWDMYSQL"]);
            this.connexion = new MySqlConnection(cs);
        }

        /// <summary>
        /// Accesseur à la propre istance de la classe
        /// En mode static pour ne pas avoir à instancier la classe .....
        /// Du coup l'attribut instance sera en static
        /// </summary>
        /// <returns></returns>
        public static Bdd getInstance()
        {
            if (Bdd.instance == null)
            {
                Bdd.instance = new Bdd();
            }
            return Bdd.instance;
        }

        public void Ouvrir()
        {
            try
            {
                if (this.connexion!=null &&  this.connexion.State==System.Data.ConnectionState.Closed)
                this.connexion.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Fermer()
        {
            try
            {
                this.connexion.Close();
                Bdd.instance = null;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public MySqlDataReader GetSports()
        {
            String sql = "select * from sport";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                return  cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public MySqlDataReader GetAdherentById(Int32 id)
        {
            String sql = "select * from adherent where id= @id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                cmd.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32));
                cmd.Parameters["id"].Value = id;
                return cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public MySqlDataReader GetAdherentBySport(int idSport)
        {
            String sql = "select adherent.id, concat(adherent.id , ' - ' , adherent.nom) as idNom " +
                " from pratique inner join adherent " +
                " on pratique.idAdherent=adherent.id" +
                " where pratique.idSport= @idSport";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                cmd.Parameters.Add(new MySqlParameter("idSport", MySqlDbType.Int32));
                cmd.Parameters["idSport"].Value = idSport;
                return cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void UpdateMail(Int32 id,String newMail)
        {
            try
            { 
                String sql = "update adherent set mail= @mail where id= @id";
                this.Ouvrir();
                    MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                    cmd.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32));
                    cmd.Parameters["id"].Value = id;
                cmd.Parameters.Add(new MySqlParameter("mail", MySqlDbType.VarChar));
                cmd.Parameters["mail"].Value = newMail;
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw new Exception("Erreur à la modification du mail de l'adhérent");
            }

        }
    }

}
