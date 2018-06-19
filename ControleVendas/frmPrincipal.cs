using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarca f = new frmMarca();
            f.ShowDialog();
        }

        private void modeloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModelo f = new frmModelo();
            f.ShowDialog();
        }

        private void novoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculo f = new frmVeiculo();
            f.ShowDialog();
        }

        private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioPeriodo f = new frmRelatorioPeriodo();
            f.ShowDialog();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor f = new frmVendedor();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCor f = new frmCor();
            f.ShowDialog();
        }

        private void porVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioVendedor f = new frmRelatorioVendedor();
            f.ShowDialog();
        }

        private void acompanharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanharVendas f = new frmAcompanharVendas();
            f.ShowDialog();
        }
    }
}
