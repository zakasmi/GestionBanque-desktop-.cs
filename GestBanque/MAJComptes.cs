using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestBanque
{
    public partial class MAJComptes : Form
    {
        public MAJComptes()
        {
            InitializeComponent();
        }
        int Pos = 0;
        bool loading = true;
        private void MAJComptes_Load(object sender, EventArgs e)
        {
            try
            {

                if (Provider.ds.Tables.Contains("Agence")) { Provider.ds.Tables["Agence"].Rows.Clear(); }
                if (Provider.ds.Tables.Contains("Client")) { Provider.ds.Tables["Client"].Rows.Clear(); }
                if (Provider.ds.Tables.Contains("Compte")) { Provider.ds.Tables["Compte"].Rows.Clear(); }

                using (SqlDataAdapter da = new SqlDataAdapter("select *from Client", Provider.cnx))
                {
                    da.Fill(Provider.ds, "Client");

                }
                using (SqlDataAdapter da = new SqlDataAdapter("select *from Agence", Provider.cnx))
                {
                    da.Fill(Provider.ds, "Agence");
                }
                using (SqlDataAdapter da = new SqlDataAdapter("select *from Compte", Provider.cnx))
                {
                    da.Fill(Provider.ds, "Compte");
                    Provider.ds.Tables["Compte"].PrimaryKey = new DataColumn[] { Provider.ds.Tables["Compte"].Columns[0] };


                }
                DataTable dt = Provider.ds.Tables["Compte"].Copy();
                LB_Agence.DataSource = Provider.ds.Tables["Agence"];
                LB_Agence.DisplayMember = "Nom_Agence";
                LB_Agence.ValueMember = "Numero_Agence";

                LB_Cin_Client.DataSource = Provider.ds.Tables["Client"];
                LB_Cin_Client.DisplayMember = "Nom_Client";
                LB_Cin_Client.ValueMember = "Cin";


            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message);

            }
            finally { loading = false; }

            
        }

        private void LB_Cin_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Cin_Client.SelectedIndex != -1 && !loading) {
                TB_CinClient.Text = LB_Cin_Client.SelectedValue.ToString();
            }
        }

        private void LB_Agence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Agence.SelectedIndex != -1 && !loading) {
                TB_NumAgence.Text = LB_Agence.SelectedValue.ToString();
            }
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            if (Provider.ds.Tables["Compte"].Rows.Count > 0) { Pos = 0;
                naviger(0);
            }
        }

        private void naviger(int x)
        {
            try
            {
                if (Provider.ds.Tables["Compte"].Rows.Count > 0 && Provider.ds.Tables["Compte"].Rows[x].RowState != DataRowState.Deleted)
                {
                    TB_NumeroCompte.Text = Provider.ds.Tables["Compte"].Rows[x][0].ToString();
                    TB_Solde.Text = Provider.ds.Tables["Compte"].Rows[x][1].ToString();
                    DTP_Dateouverture.Value = DateTime.Parse(Provider.ds.Tables["Compte"].Rows[x][2].ToString());
                    TB_CinClient.Text = Provider.ds.Tables["Compte"].Rows[x][3].ToString();
                    TB_NumAgence.Text = Provider.ds.Tables["Compte"].Rows[x][4].ToString();

                }
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);
            }


        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Compte"].Rows.Count;
            if (count > 0)
            {
                Pos = count-1 ;
                naviger(Pos);
            }
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Compte"].Rows.Count;
            if (Pos < count-1)
            {
                Pos++;
                naviger(Pos);

            }
        }

        private void BTN_precedent_Click(object sender, EventArgs e)
        {
            if (Pos > 0)
            {
                Pos--;
                naviger(Pos);

            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Provider.ds.Tables["Compte"].NewRow();

                dr[0] = TB_NumeroCompte.Text;
                dr[1] = TB_Solde.Text;
                dr[2] = DTP_Dateouverture.Value;
                dr[3] = TB_CinClient.Text;
                dr[4] = TB_NumAgence.Text;

                Provider.ds.Tables["Compte"].Rows.Add(dr);
                MessageBox.Show("Ajouté avec Succes");

            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Provider.ds.Tables["Compte"].Rows.Find(TB_NumeroCompte.Text);

                dr[0] = TB_NumeroCompte.Text;
                dr[1] = TB_Solde.Text;
                dr[2] = DTP_Dateouverture.Value;
                dr[3] = TB_CinClient.Text;
                dr[4] = TB_NumAgence.Text;

               
                MessageBox.Show("Modifié avec Succes");

            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Provider.ds.Tables["Compte"].Rows.Find(TB_NumeroCompte.Text).Delete();
                
                MessageBox.Show("Supprimée avec Succes");

            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select *from Compte", Provider.cnx))
                {
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(Provider.ds.Tables["Compte"]);
                    MessageBox.Show("Enregistre avec succes");
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
    }
}
