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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }

        bool carregaForm = true;

        private void CarregarCor()
        {
            CorDAO dao = new CorDAO();

            cmbCor.DataSource = dao.ConsultarCor(Util.CodigoLogado);
        }

        private void CarregarMarca()
        {
            MarcaDAO dao = new MarcaDAO();

            cmbMarca.DataSource = dao.ConsultarMarcas(Util.CodigoLogado);
        }

        private void CarregarModelo(int codMarca)
        {
            ModeloDAO dao = new ModeloDAO();

            cmbModelo.DataSource = dao.FiltrarModelo(codMarca);
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtObs.Clear();
            txtAnoFabricacao.Clear();
            txtAnoVeiculo.Clear();
            txtKm.Clear();
            txtPlacaPesquisa.Clear();
            txtPlaca.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            cmbAirBag.SelectedIndex = -1;
            cmbCor.SelectedIndex = -1;
            cmbDirecao.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbModelo.SelectedIndex = -1;
            cmbNumPortas.SelectedIndex = -1;
            cmbSituacao.SelectedIndex = -1;
            chkAbs.Checked = false;
            chkAr.Checked = false;
        }        

        private bool ValidarCampos()
        {
            bool ret = true;

            string campos = "";

            if (txtPlaca.Text.Trim() == string.Empty)
            {
                campos += "- Placa\n";
                ret = false;
            }
            if (cmbMarca.SelectedIndex == -1)
            {
                campos += "- Marca\n";
                ret = false;
            }
            if (cmbModelo.SelectedIndex == -1)
            {
                campos += "- Modelo\n";
                ret = false;
            }
            if (txtAnoFabricacao.Text.Trim() == string.Empty)
            {
                campos += "- Ano Fabricação\n";
                ret = false;
            }
            if(txtAnoVeiculo.Text.Trim() == string.Empty)
            {
                campos += "- Ano veículo\n";
                ret = false;
            }
            if(txtKm.Text.Trim() == string.Empty)
            {
                campos += "- Km\n";
                ret = false;
            }
            if (cmbCor.SelectedIndex == -1)
            {
                campos += "- Cor\n";
                ret = false;
            }
            if (cmbNumPortas.SelectedIndex == -1)
            {
                campos += "- Número de portas\n";
                ret = false;
            }
            if (cmbDirecao.SelectedIndex == -1)
            {
                campos += "- Direção\n";
                ret = false;
            }
            if (cmbAirBag.SelectedIndex == -1)
            {
                campos += "- Airbag\n";
                ret = false;
            }
            if (txtValorCompra.Text.Trim() == string.Empty)
            {
                campos += "- Valor da compra\n";
                ret = false;
            }
            if (txtValorVenda.Text.Trim() == string.Empty)
            {
                campos += "- Valor da venda\n";
                ret = false;
            }
            if (cmbSituacao.SelectedIndex == -1)
            {
                campos += "- Situação\n";
                ret = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                VeiculoDAO dao = new VeiculoDAO();
                tb_veiculo objVeiculo = new tb_veiculo();

                //Preenche os valores das combos
                objVeiculo.airbag_veiculo = Convert.ToInt16(cmbAirBag.SelectedIndex + 1);
                objVeiculo.cod_modelo = Convert.ToInt32(cmbModelo.SelectedValue);
                objVeiculo.cod_cor = Convert.ToInt32(cmbCor.SelectedValue);
                objVeiculo.num_porta = (cmbNumPortas.SelectedIndex == 0 ? "4" : "2");
                objVeiculo.direcao_veiculo = Convert.ToInt16(cmbDirecao.SelectedIndex + 1);
                objVeiculo.situacao_veiculo = Convert.ToInt16(cmbSituacao.SelectedIndex + 1);

                //Preenche os valores dos checkboxes
                objVeiculo.ar_condicionado = chkAr.Checked;
                objVeiculo.freio_abs = chkAbs.Checked;

                //Preenche os demais campos
                objVeiculo.placa_veiculo = txtPlaca.Text.Trim();
                objVeiculo.ano_fabricacao = txtAnoFabricacao.Text.Trim();
                objVeiculo.ano_carro = txtAnoVeiculo.Text.Trim();
                objVeiculo.km_veiculo = txtKm.Text.Trim();
                objVeiculo.valor_compra = Convert.ToDecimal(txtValorCompra.Text);
                objVeiculo.valor_venda = Convert.ToDecimal(txtValorVenda.Text);
                objVeiculo.cod_empresa = Util.CodigoLogado;
                objVeiculo.obs_veiculo = txtObs.Text.Trim();
                objVeiculo.data_cadastro = DateTime.Now;


                try
                {
                    if(txtCodigo.Text.Trim() == string.Empty)
                    {
                        dao.InserirVeiculo(objVeiculo);
                    }
                    else
                    {
                        objVeiculo.cod_veiculo = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarVeiculo(objVeiculo);
                    }

                    LimparCampos();
                    ConsultarVeiculo();
                    Util.ExibirMsgGeral(Util.TipoMsg.Sucesso);
                }
                catch (Exception)
                {
                    Util.ExibirMsgGeral(Util.TipoMsg.Erro);
                }
            }
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarCor();
            CarregarMarca();
            LimparCampos();
            ConsultarVeiculo();
            carregaForm = false;

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMarca.SelectedIndex > -1 && carregaForm == false)
            {
                CarregarModelo(Convert.ToInt32(cmbMarca.SelectedValue));
            }
        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdResultado.RowCount > 0)
            {                    //Cast
                VeiculoVO vo = (VeiculoVO)grdResultado.CurrentRow.DataBoundItem;

                txtCodigo.Text = vo.codigo_veiculo.ToString();
                txtAnoFabricacao.Text = vo.ano_fabricacao;
                txtAnoVeiculo.Text = vo.ano_veiculo;
                txtKm.Text = vo.km;
                txtObs.Text = vo.obs;
                txtPlaca.Text = vo.placa;
                txtValorCompra.Text = vo.valor_compra.ToString();
                txtValorVenda.Text = vo.valor_venda.ToString();
                cmbAirBag.SelectedIndex = vo.airbag - 1;
                cmbDirecao.SelectedIndex = vo.direcao - 1;
                cmbCor.SelectedValue = vo.codigo_cor;

                cmbMarca.SelectedValue = vo.codigo_marca;
                cmbModelo.SelectedValue = vo.codigo_modelo;

                cmbNumPortas.SelectedIndex = (vo.portas == "2" ? 0 : 1);
                cmbSituacao.SelectedIndex = vo.situacao - 1;
                
                chkAr.Checked = vo.ar;
                chkAbs.Checked = vo.abs;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void txtPlacaPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtPlacaPesquisa.Text.Trim() != string.Empty)
            {
                ConsultarVeiculo();
            }
        }

        private void ConsultarVeiculo()
        {
            VeiculoDAO dao = new VeiculoDAO();
            List<VeiculoVO> Lista = dao.ConsultarVeiculo(txtPlacaPesquisa.Text.Trim(), Util.CodigoLogado);

            grdResultado.DataSource = Lista;

            grdResultado.Columns["codigo_veiculo"].Visible = false;
            grdResultado.Columns["codigo_marca"].Visible = false;
            grdResultado.Columns["codigo_modelo"].Visible = false;
            grdResultado.Columns["codigo_cor"].Visible = false;
            grdResultado.Columns["obs"].Visible = false;
            grdResultado.Columns["ar"].Visible = false;
            grdResultado.Columns["situacao"].Visible = false;
            grdResultado.Columns["codigo_cor"].Visible = false;
            grdResultado.Columns["airbag"].Visible = false;
            grdResultado.Columns["direcao"].Visible = false;
            grdResultado.Columns["portas"].Visible = false;
            grdResultado.Columns["km"].Visible = false;
            grdResultado.Columns["cor"].Visible = false;
            grdResultado.Columns["abs"].Visible = false;
            grdResultado.Columns["valor_compra"].Visible = false;
            grdResultado.Columns["valor_venda"].Visible = false;

            grdResultado.Columns["ano_fabricacao"].HeaderText = "Ano Fabricação";
            grdResultado.Columns["ano_veiculo"].HeaderText = "Ano Veículo";
            grdResultado.Columns["marca"].HeaderText = "Marca";
            grdResultado.Columns["modelo"].HeaderText = "Modelo";
            grdResultado.Columns["placa"].HeaderText = "Placa";
        }
    }
}
