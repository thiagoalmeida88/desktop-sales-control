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
    public partial class frmRelatorioVendedor : Form
    {
        public frmRelatorioVendedor()
        {
            InitializeComponent();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            RelatorioDAO dao = new RelatorioDAO();

            List<RelatorioVendedorVO> ListaRetorno = dao.EmitirPorVendedor(Convert.ToInt32(cboVendedor.SelectedValue));

            if (ListaRetorno.Count > 0)
            {
                frmResultadoVendedorRel frm = new frmResultadoVendedorRel();

                frm.CarregarRelatorio(ListaRetorno);

                frm.ShowDialog();
            }
            else
            {
                Util.ExibirMsgGeral(Util.TipoMsg.ConsultaSemRetorno);
            }

        }

        private void CarregarVendedores()
        {
            VendedorDAO dao = new VendedorDAO();

            List<tb_vendedor_sistema> ListaVendedor = dao.ConsultarVendedores(Util.CodigoLogado);

            cboVendedor.DataSource = ListaVendedor;

        }

        private void frmRelatorioVendedor_Load(object sender, EventArgs e)
        {
            CarregarVendedores();
        }
    }
}
