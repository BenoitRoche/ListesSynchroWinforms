using MySql.Data.MySqlClient;
using Sport.ClassesTechniques;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sport
{
    public partial class FrmSport : Form
    {
        private bool listeSportChargee = false;
        private bool sportChange = true;
        private Regex regxMail;
        public FrmSport()
        {
            InitializeComponent();
        }

       
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
        
        private void rien()
        {
            int i = 0;
        }


        private void FrmSport_Load(object sender, EventArgs e)
        {
            Bdd bdd = Bdd.getInstance();
            bdd.Ouvrir();
            MySqlDataReader reader = bdd.GetSports();            
            DataTable dt = new DataTable();
            dt.Load(reader);

            cmbSports.DataSource = dt;
            cmbSports.ValueMember = "id";
            cmbSports.DisplayMember = "libelle";
            bdd.Fermer();
            cmbSports.Text = "-- sélectionnez --";
            this.listeSportChargee = true;
            pnlAdherent.Enabled = false;
            String emailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                    + "@"
                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z"; 
            this.regxMail = new Regex(emailPattern);
        }

        private void cmbSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear des zones d'affichage
            txtId.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtMail.Clear();

            // On ne charge la liste des adhérents que si la liste sports est entièrement chargée
            if (this.listeSportChargee)
            {
                Bdd bdd = Bdd.getInstance();
                bdd.Ouvrir();

                cmbAdherents.Enabled = true;                
                DataTable dt = new DataTable();
                dt.Load(bdd.GetAdherentBySport((int)cmbSports.SelectedValue));


                this.sportChange = true;
                cmbAdherents.DataSource = dt;
                cmbAdherents.ValueMember = "id";
                cmbAdherents.DisplayMember = "idNom";
                cmbAdherents.Text = "-- sélectionnez --";
                pnlAdherent.Enabled = false;
                bdd.Fermer();
                this.sportChange = false;


            }
        }

        private void cmbAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.sportChange)
            {
                pnlAdherent.Enabled = true;
                Bdd bdd = Bdd.getInstance();
                bdd.Ouvrir();
                MySqlDataReader reader = bdd.GetAdherentById((int)cmbAdherents.SelectedValue);
                if (reader.HasRows)
                {
                    reader.Read();
                    txtId.Text = reader.GetInt32("id").ToString();
                    txtNom.Text = reader.GetString("nom");
                    txtPrenom.Text = reader.GetString("prenom");
                    txtMail.Text = reader.GetString("mail");
                    lblModifMail.Visible = false;
                    btnModifMail.Enabled = false;
                }
                bdd.Fermer();
            }

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (this.regxMail.IsMatch(txtMail.Text))
            {
                btnModifMail.Enabled = true;
            }
            else
            {
                btnModifMail.Enabled = false;
            }
        }

        private void btnModifMail_Click(object sender, EventArgs e)
        {Bdd bdd = Bdd.getInstance();
            try
            {
                
                bdd.Ouvrir();
                bdd.UpdateMail(Convert.ToInt32(txtId.Text), txtMail.Text);
                lblModifMail.Text = "Mise à jour effectuée";
                lblModifMail.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblModifMail.Text = ex.Message;
                lblModifMail.ForeColor = Color.Red;
            }
            finally
            {
                lblModifMail.Visible = true;
                btnModifMail.Enabled=false;
                bdd.Fermer();
            }
            
        }
    }
}


