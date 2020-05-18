namespace Sport
{
    partial class FrmSport
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.grpAdherents = new System.Windows.Forms.GroupBox();
            this.pnlAdherent = new System.Windows.Forms.Panel();
            this.lblModifMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdherents = new System.Windows.Forms.ComboBox();
            this.cmbSports = new System.Windows.Forms.ComboBox();
            this.btnModifMail = new System.Windows.Forms.Button();
            this.grpAdherents.SuspendLayout();
            this.pnlAdherent.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(52, 305);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(654, 40);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // grpAdherents
            // 
            this.grpAdherents.AutoSize = true;
            this.grpAdherents.Controls.Add(this.pnlAdherent);
            this.grpAdherents.Controls.Add(this.label2);
            this.grpAdherents.Controls.Add(this.label1);
            this.grpAdherents.Controls.Add(this.cmbAdherents);
            this.grpAdherents.Controls.Add(this.cmbSports);
            this.grpAdherents.Location = new System.Drawing.Point(12, 29);
            this.grpAdherents.Name = "grpAdherents";
            this.grpAdherents.Size = new System.Drawing.Size(717, 251);
            this.grpAdherents.TabIndex = 4;
            this.grpAdherents.TabStop = false;
            this.grpAdherents.Text = "Adhérents";
            // 
            // pnlAdherent
            // 
            this.pnlAdherent.Controls.Add(this.lblModifMail);
            this.pnlAdherent.Controls.Add(this.txtMail);
            this.pnlAdherent.Controls.Add(this.btnModifMail);
            this.pnlAdherent.Controls.Add(this.label6);
            this.pnlAdherent.Controls.Add(this.label5);
            this.pnlAdherent.Controls.Add(this.label4);
            this.pnlAdherent.Controls.Add(this.label3);
            this.pnlAdherent.Controls.Add(this.txtId);
            this.pnlAdherent.Controls.Add(this.txtPrenom);
            this.pnlAdherent.Controls.Add(this.txtNom);
            this.pnlAdherent.Location = new System.Drawing.Point(57, 81);
            this.pnlAdherent.Name = "pnlAdherent";
            this.pnlAdherent.Size = new System.Drawing.Size(654, 151);
            this.pnlAdherent.TabIndex = 4;
            // 
            // lblModifMail
            // 
            this.lblModifMail.Location = new System.Drawing.Point(79, 107);
            this.lblModifMail.Name = "lblModifMail";
            this.lblModifMail.Size = new System.Drawing.Size(450, 20);
            this.lblModifMail.TabIndex = 10;
            this.lblModifMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(79, 84);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(450, 20);
            this.txtMail.TabIndex = 9;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(450, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(79, 55);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(450, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(79, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(450, 20);
            this.txtNom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adhérents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sports";
            // 
            // cmbAdherents
            // 
            this.cmbAdherents.Enabled = false;
            this.cmbAdherents.FormattingEnabled = true;
            this.cmbAdherents.Items.AddRange(new object[] {
            "-- sélectionnez --",
            "1-Dupont Jean",
            "2-Durand Valérie",
            "3- Charpentier Alain",
            "4-Luneau Daniel",
            "5- Russot Sophie",
            "6- Sanchez Murielle"});
            this.cmbAdherents.Location = new System.Drawing.Point(404, 34);
            this.cmbAdherents.Name = "cmbAdherents";
            this.cmbAdherents.Size = new System.Drawing.Size(242, 21);
            this.cmbAdherents.TabIndex = 1;
            this.cmbAdherents.Text = "-- sélectionnez --";
            this.cmbAdherents.SelectedIndexChanged += new System.EventHandler(this.cmbAdherents_SelectedIndexChanged);
            // 
            // cmbSports
            // 
            this.cmbSports.FormattingEnabled = true;
            this.cmbSports.Items.AddRange(new object[] {
            ""});
            this.cmbSports.Location = new System.Drawing.Point(72, 34);
            this.cmbSports.Name = "cmbSports";
            this.cmbSports.Size = new System.Drawing.Size(212, 21);
            this.cmbSports.TabIndex = 0;
            this.cmbSports.Text = "-- sélectionnez --";
            this.cmbSports.SelectedIndexChanged += new System.EventHandler(this.cmbSports_SelectedIndexChanged);
            // 
            // btnModifMail
            // 
            this.btnModifMail.Enabled = false;
            this.btnModifMail.Location = new System.Drawing.Point(548, 80);
            this.btnModifMail.Name = "btnModifMail";
            this.btnModifMail.Size = new System.Drawing.Size(103, 26);
            this.btnModifMail.TabIndex = 8;
            this.btnModifMail.Text = "Modifier";
            this.btnModifMail.UseVisualStyleBackColor = true;
            this.btnModifMail.Click += new System.EventHandler(this.btnModifMail_Click);
            // 
            // FrmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.grpAdherents);
            this.Controls.Add(this.BtnQuitter);
            this.Name = "FrmSport";
            this.Text = "Sports";
            this.Load += new System.EventHandler(this.FrmSport_Load);
            this.grpAdherents.ResumeLayout(false);
            this.grpAdherents.PerformLayout();
            this.pnlAdherent.ResumeLayout(false);
            this.pnlAdherent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.GroupBox grpAdherents;
        private System.Windows.Forms.ComboBox cmbSports;
        private System.Windows.Forms.Panel pnlAdherent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAdherents;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblModifMail;
        private System.Windows.Forms.Button btnModifMail;
    }
}

