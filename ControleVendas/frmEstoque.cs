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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void FecharTela()
        {
            this.Close();       
        }
        
        private bool ValidarCampos()
        {
            bool ret = true;

            string campos = "";

            if(cmbSituacao.SelectedIndex < 0)
            {
                campos += "- Situação\n"; 
            }
            if(txtCodigo.Text.Trim() == string.Empty)
            {
                campos += "- Codigo";
            }

            if (!ret)
            {
                Util.ExibirMsgValidacao(campos);
            }

            return ret;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }
    }
}
