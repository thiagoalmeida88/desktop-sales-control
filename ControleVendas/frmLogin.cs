using DAO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                EmpresaDAO dao = new EmpresaDAO();

                tb_empresa empresa = dao.ValidarLogin(txtCnpj.Text.Trim(), txtSenha.Text.Trim());

                if (empresa != null)
                {
                    Util.CodigoLogado = empresa.cod_empresa;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Util.ExibirMsgGeral(Util.TipoMsg.UsuarioNaoEncontrado);

                }
            }            
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtCnpj.Text.Trim() == string.Empty)
            {
                campos += "- CNPJ\n";
                ret = false;
            }

            if (txtSenha.Text.Trim() == string.Empty)
            {
                campos += "- Senha\n";
                ret = false;
            }

            if (!ret)
            {
                Util.ExibirMsgValidacao(campos);
            }

            return ret;

        }


    }
}
