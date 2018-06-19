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
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtModelo.Clear();
            cmbMarcas.SelectedIndex = -1;
        }

        private void CarregarGrid()
        {
            ModeloDAO dao = new ModeloDAO();
            List<ModeloVO> ListaModelos = dao.ConsultarModelos(Util.CodigoLogado);

            if(ListaModelos.Count > 0)
            {
                grdModelos.DataSource = ListaModelos;

                grdModelos.Columns["codigo_modelo"].Visible = false;
                grdModelos.Columns["codigo_marca"].Visible = false;
             

                grdModelos.Columns["modelo"].HeaderText = "Modelo";
                grdModelos.Columns["marca"].HeaderText = "Marca";               

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                tb_modelo objModelo = new tb_modelo();
                ModeloDAO dao = new ModeloDAO();

                objModelo.nome_modelo = txtModelo.Text.Trim();
                objModelo.cod_marca= Convert.ToInt32(cmbMarcas.SelectedValue);
                objModelo.cod_empresa = Util.CodigoLogado;

                try
                {
                    if(txtCodigo.Text.Trim() == string.Empty)
                    {
                        dao.InserirModelo(objModelo);
                    }
                    else
                    {
                        objModelo.cod_modelo = Convert.ToInt32(txtCodigo.Text);                        
                        dao.AlterarModelo(objModelo);
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

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if(cmbMarcas.SelectedIndex < 0)
            {
                campos += "- Marca\n";
                ret = false;
            }

            if(txtModelo.Text.Trim() == string.Empty)
            {
                campos += "- Modelo\n";
                ret = false;
            }

            if(!ret)
            {
                Util.ExibirMsgValidacao(campos);
            }

            return ret;
        }       

        private void CarregarMarcas()
        {
            MarcaDAO dao = new MarcaDAO();
            List<tb_marca> ListaMarca = dao.ConsultarMarcas(Util.CodigoLogado);

            cmbMarcas.DataSource = ListaMarca;
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
            CarregarGrid();
            LimparCampos();
        }

        private void grdModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdModelos.RowCount > 0)
            {
                ModeloVO objRecuperado = (ModeloVO)grdModelos.CurrentRow.DataBoundItem;

                txtCodigo.Text = objRecuperado.codigo_modelo.ToString();
                txtModelo.Text = objRecuperado.modelo;
                cmbMarcas.SelectedValue = objRecuperado.codigo_marca;
            }
        }
    }
}
