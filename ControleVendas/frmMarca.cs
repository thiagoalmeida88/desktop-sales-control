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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            MarcaDAO dao = new MarcaDAO();
            List<tb_marca> ListaMarcas = dao.ConsultarMarcas(Util.CodigoLogado);

            if(ListaMarcas.Count > 0)
            {
                grdMarcas.DataSource = ListaMarcas;

                grdMarcas.Columns["cod_marca"].Visible = false;
                grdMarcas.Columns["cod_empresa"].Visible = false;
                grdMarcas.Columns["tb_empresa"].Visible = false;
                grdMarcas.Columns["tb_modelo"].Visible = false;

                grdMarcas.Columns["nome_marca"].HeaderText = "Marca";

            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campo = "";

            if(txtMarca.Text.Trim() == string.Empty)
            {
                campo += "Nome da marca";
                ret = false;
            }

            if(!ret)
            {
                Util.ExibirMsgValidacao(campo);
            }

            return ret;            
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtMarca.Clear();
                
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                tb_marca objMarca = new tb_marca();
                MarcaDAO dao = new MarcaDAO();

                objMarca.nome_marca = txtMarca.Text.Trim();
                objMarca.cod_empresa = Util.CodigoLogado;

                try
                {
                    //Verifica se é uma inserção
                    if (txtCodigo.Text.Trim() == string.Empty)
                    {
                        dao.InserirMarca(objMarca);
                    }
                    else //Se não, é uma alteração
                    {
                        objMarca.cod_marca = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarMarca(objMarca);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void grdMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica se existe linhas na grid
            if(grdMarcas.RowCount > 0)
            {
                //Recupera o objeto da linha clicada
                tb_marca objRecuperado = (tb_marca)grdMarcas.CurrentRow.DataBoundItem;

                txtCodigo.Text = objRecuperado.cod_marca.ToString();
                txtMarca.Text = objRecuperado.nome_marca;
            }
        }
    }
}
