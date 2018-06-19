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
    public partial class frmAcompanharVendas : Form
    {
        public frmAcompanharVendas()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            VendaDAO dao = new VendaDAO();
            List<VendaVO> ListaVendas = dao.ConsultarVendas(Util.CodigoLogado);

            if (ListaVendas.Count > 0)
            {
                grdAcompanharVendas.DataSource = ListaVendas;

                grdAcompanharVendas.Columns["cod_venda"].Visible = false;
                grdAcompanharVendas.Columns["cod_veiculo"].Visible = false;
                grdAcompanharVendas.Columns["cod_cliente"].Visible = false;
                grdAcompanharVendas.Columns["cod_vendedor"].Visible = false;

                grdAcompanharVendas.Columns["nome_veiculo"].HeaderText = "Veículo";
                grdAcompanharVendas.Columns["nome_cliente"].HeaderText = "Cliente";
                grdAcompanharVendas.Columns["nome_vendedor"].HeaderText = "Vendedor";
                grdAcompanharVendas.Columns["data_venda"].HeaderText = "Data Venda";
                grdAcompanharVendas.Columns["forma_pagamento"].HeaderText = "Forma Pagamento";
                grdAcompanharVendas.Columns["obs_venda"].HeaderText = "Observação";

            }

        }

        private void FecharTela()
        {
            this.Close();
        }

        private void frmAcompanharVendas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }
    }
}
