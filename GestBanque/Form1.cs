using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestBanque
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mAJComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJComptes M = new MAJComptes();
            M.ShowDialog();

        }

        private void chercherCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChercherComptes CC = new ChercherComptes();
            CC.ShowDialog();

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherClient CC = new AfficherClient();
            CC.ShowDialog();

        }
    }
}
