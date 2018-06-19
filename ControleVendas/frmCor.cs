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
    public partial class frmCor : Form
    {
        public frmCor()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtCor.Clear();
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if(txtCor.Text.Trim() == string.Empty)
            {
                campos = "Nome da cor";
                ret = false;
            }

            if (!ret)
            {
                Util.ExibirMsgValidacao(campos);
            }

            return ret;
        }

        private void CarregarGrid()
        {
            CorDAO dao = new CorDAO();

            List<tb_cor> ListaCores = dao.ConsultarCor(Util.CodigoLogado);

            if (ListaCores.Count > 0)
            {
                grdCores.DataSource = ListaCores;

                grdCores.Columns["cod_cor"].Visible = false;
                grdCores.Columns["tb_veiculo"].Visible = false;
                grdCores.Columns["tb_empresa"].Visible = false;
                grdCores.Columns["cod_empresa"].Visible = false;

                grdCores.Columns["nome_cor"].HeaderText = "Nome da cor";

            }
        }

        private void FecharTela()
        {
            this.Close();
        }
        
        private void grdModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCores.RowCount > 0)
            {
                tb_cor objRecuperado = (tb_cor)grdCores.CurrentRow.DataBoundItem;

                txtCodigo.Text = objRecuperado.cod_cor.ToString();
                txtCor.Text = objRecuperado.nome_cor;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CorDAO dao = new CorDAO();
            tb_cor objCor = new tb_cor();

            objCor.cod_empresa = Util.CodigoLogado;
            objCor.nome_cor = txtCor.Text.Trim();

            try
            {
                if(txtCodigo.Text.Trim() == string.Empty)
                {
                    dao.InserirCor(objCor);
                }
                else
                {
                    objCor.cod_cor = Convert.ToInt32(txtCodigo.Text);
                    dao.AlterarCor(objCor);
                }

                LimparCampos();
                CarregarGrid();
                Util.ExibirMsgGeral(Util.TipoMsg.Sucesso);
            }
            catch (Exception)
            {
                Util.ExibirMsgGeral(Util.TipoMsg.Erro);                
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmCor_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
