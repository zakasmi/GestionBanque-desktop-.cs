namespace GestBanque
{
    partial class MAJComptes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_precedent = new System.Windows.Forms.Button();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.TB_NumeroCompte = new System.Windows.Forms.TextBox();
            this.TB_Solde = new System.Windows.Forms.TextBox();
            this.TB_CinClient = new System.Windows.Forms.TextBox();
            this.TB_NumAgence = new System.Windows.Forms.TextBox();
            this.DTP_Dateouverture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Agence = new System.Windows.Forms.ListBox();
            this.LB_Cin_Client = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(171, 287);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(273, 287);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 0;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(380, 287);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Location = new System.Drawing.Point(482, 287);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Enregistrer.TabIndex = 0;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(171, 332);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(75, 23);
            this.BTN_Debut.TabIndex = 0;
            this.BTN_Debut.Text = "<<";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_precedent
            // 
            this.BTN_precedent.Location = new System.Drawing.Point(273, 332);
            this.BTN_precedent.Name = "BTN_precedent";
            this.BTN_precedent.Size = new System.Drawing.Size(75, 23);
            this.BTN_precedent.TabIndex = 0;
            this.BTN_precedent.Text = "<";
            this.BTN_precedent.UseVisualStyleBackColor = true;
            this.BTN_precedent.Click += new System.EventHandler(this.BTN_precedent_Click);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(380, 332);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(75, 23);
            this.BTN_Suivant.TabIndex = 0;
            this.BTN_Suivant.Text = ">";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(482, 332);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fin.TabIndex = 0;
            this.BTN_Fin.Text = ">>";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // TB_NumeroCompte
            // 
            this.TB_NumeroCompte.Location = new System.Drawing.Point(128, 54);
            this.TB_NumeroCompte.Name = "TB_NumeroCompte";
            this.TB_NumeroCompte.Size = new System.Drawing.Size(137, 20);
            this.TB_NumeroCompte.TabIndex = 1;
            // 
            // TB_Solde
            // 
            this.TB_Solde.Location = new System.Drawing.Point(128, 91);
            this.TB_Solde.Name = "TB_Solde";
            this.TB_Solde.Size = new System.Drawing.Size(137, 20);
            this.TB_Solde.TabIndex = 1;
            // 
            // TB_CinClient
            // 
            this.TB_CinClient.Location = new System.Drawing.Point(128, 171);
            this.TB_CinClient.Name = "TB_CinClient";
            this.TB_CinClient.Size = new System.Drawing.Size(137, 20);
            this.TB_CinClient.TabIndex = 1;
            // 
            // TB_NumAgence
            // 
            this.TB_NumAgence.Location = new System.Drawing.Point(128, 206);
            this.TB_NumAgence.Name = "TB_NumAgence";
            this.TB_NumAgence.Size = new System.Drawing.Size(138, 20);
            this.TB_NumAgence.TabIndex = 1;
            // 
            // DTP_Dateouverture
            // 
            this.DTP_Dateouverture.CustomFormat = "dd/MM/yyyy";
            this.DTP_Dateouverture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Dateouverture.Location = new System.Drawing.Point(128, 135);
            this.DTP_Dateouverture.Name = "DTP_Dateouverture";
            this.DTP_Dateouverture.Size = new System.Drawing.Size(138, 20);
            this.DTP_Dateouverture.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Ouverture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cin Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numero Agence";
            // 
            // LB_Agence
            // 
            this.LB_Agence.FormattingEnabled = true;
            this.LB_Agence.Location = new System.Drawing.Point(374, 54);
            this.LB_Agence.Name = "LB_Agence";
            this.LB_Agence.Size = new System.Drawing.Size(120, 173);
            this.LB_Agence.TabIndex = 4;
            this.LB_Agence.SelectedIndexChanged += new System.EventHandler(this.LB_Agence_SelectedIndexChanged);
            // 
            // LB_Cin_Client
            // 
            this.LB_Cin_Client.FormattingEnabled = true;
            this.LB_Cin_Client.Location = new System.Drawing.Point(554, 54);
            this.LB_Cin_Client.Name = "LB_Cin_Client";
            this.LB_Cin_Client.Size = new System.Drawing.Size(120, 173);
            this.LB_Cin_Client.TabIndex = 4;
            this.LB_Cin_Client.SelectedIndexChanged += new System.EventHandler(this.LB_Cin_Client_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Numero Agence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cin Client";
            // 
            // MAJComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 398);
            this.Controls.Add(this.LB_Cin_Client);
            this.Controls.Add(this.LB_Agence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTP_Dateouverture);
            this.Controls.Add(this.TB_NumAgence);
            this.Controls.Add(this.TB_CinClient);
            this.Controls.Add(this.TB_Solde);
            this.Controls.Add(this.TB_NumeroCompte);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_precedent);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Ajouter);
            this.Name = "MAJComptes";
            this.Text = "MAJComptes";
            this.Load += new System.EventHandler(this.MAJComptes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_precedent;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.TextBox TB_NumeroCompte;
        private System.Windows.Forms.TextBox TB_Solde;
        private System.Windows.Forms.TextBox TB_CinClient;
        private System.Windows.Forms.TextBox TB_NumAgence;
        private System.Windows.Forms.DateTimePicker DTP_Dateouverture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LB_Agence;
        private System.Windows.Forms.ListBox LB_Cin_Client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}