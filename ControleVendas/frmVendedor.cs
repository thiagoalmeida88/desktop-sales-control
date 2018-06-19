using DAO;
using DAO.VO;
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
    public partial class frmVendedor : Form
    {
        public object VendedorDAO { get; private set; }

        public frmVendedor()
        {
            InitializeComponent();
            chkAtivo.Checked = true;
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void CarregarGrid()
        {

            VendedorDAO dao = new VendedorDAO();
            List<VendedorVO> ListaVendedor = dao.ConsultarVendedor(Util.CodigoLogado);

            if(ListaVendedor.Count > 0)
            {
                grdVendedor.DataSource = ListaVendedor;
                                
                grdVendedor.Columns["codigo_vendedor"].Visible = false;
                grdVendedor.Columns["senha"].Visible = false;

                grdVendedor.Columns["vendedor"].HeaderText = "Vendedor";
                grdVendedor.Columns["email"].HeaderText = "Email";
                grdVendedor.Columns["celular"].HeaderText = "Celular";               
                grdVendedor.Columns["endereco"].HeaderText = "Endereço";
                grdVendedor.Columns["status"].HeaderText = "Status";
                
                for (int i = 0; i < ListaVendedor.Count; i++)
                {
                   if (Convert.ToString(grdVendedor.Rows[i].Cells[5].Value) == "Inativo")
                   {

                       grdVendedor.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                   }                                       
                }                    
             }               
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtVendedor.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtSenha.Clear();
            chkAtivo.Checked = true;
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            
            if (txtVendedor.Text.Trim() == string.Empty)
            {
                campos += "- Nome\n";
                ret = false;
            }
            if (txtEmail.Text.Trim() == string.Empty)
            {
                campos += "- Email\n";
                ret = false;
            }
            if (txtCelular.Text.Trim() == string.Empty)
            {
                campos += "- Celular\n";
                ret = false;
            }
            if (txtEndereco.Text.Trim() == string.Empty)
            {
                campos += "- Endereço\n";
                ret = false;
            }           
            if(txtSenha.Text.Trim() == string.Empty)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_vendedor_sistema objVendedor = new tb_vendedor_sistema();
                VendedorDAO dao = new VendedorDAO();

                objVendedor.nome_vendedor = txtVendedor.Text;
                objVendedor.email_vendedor = txtEmail.Text;
                objVendedor.celular_vendedor = txtCelular.Text;
                objVendedor.endereco_vendedor = txtEndereco.Text;                
                objVendedor.senha_vendedor = txtSenha.Text;
                objVendedor.cod_empresa = Util.CodigoLogado;
                objVendedor.status_vendedor = Convert.ToBoolean(chkAtivo.Checked);


                try
                {
                    if(txtCodigo.Text.Trim() == string.Empty)
                    {
                        dao.InserirVendedor(objVendedor);
                    }
                    else
                    {
                        objVendedor.cod_vendedor = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarVendedor(objVendedor);
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
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            txtVendedor.Select();
            rdoVendedor.Checked = true;
            CarregarGrid();
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void grdVendedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdVendedor.RowCount > 0)
            {
                VendedorVO objRecuperado = (VendedorVO)grdVendedor.CurrentRow.DataBoundItem;

                txtCodigo.Text = objRecuperado.codigo_vendedor.ToString();
                txtVendedor.Text = objRecuperado.vendedor;
                txtEmail.Text = objRecuperado.email;
                txtCelular.Text = objRecuperado.celular;
                txtEndereco.Text = objRecuperado.endereco;
                txtSenha.Text = objRecuperado.senha;    
                
                if(Convert.ToString(objRecuperado.status) == "Inativo")
                {
                    chkAtivo.Checked = false;
                }
                else
                {
                    chkAtivo.Checked = true;
                }

            }
        }
        
        private void txtPesquisarVendedor_TextChanged(object sender, EventArgs e)
        {

            var radioButtons = gbRadioButton.Controls.OfType<RadioButton>();

            string opcaoPesquisa = "";

            foreach (RadioButton rb in radioButtons)
            {
                bool estado = rb.Checked;
                string nome = rb.Name;

                if (estado == true)
                {
                    opcaoPesquisa = nome;
                }
            }
            
            if (txtPesquisarVendedor.Text.Trim() != string.Empty)
            {                
                VendedorDAO dao = new VendedorDAO();

                List<VendedorVO> PesquisaVendedor = dao.PesquisarVendedor(Util.CodigoLogado, txtPesquisarVendedor.Text, opcaoPesquisa);
                
                grdVendedor.DataSource = PesquisaVendedor;

                for (int i = 0; i < PesquisaVendedor.Count; i++)
                {
                    if (Convert.ToString(grdVendedor.Rows[i].Cells[5].Value) == "Inativo")
                    {

                        grdVendedor.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                    }
                }
                grdVendedor.Update();
                
            }
            else
            {
                CarregarGrid();
            }
        }
    }
}
