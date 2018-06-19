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
    public partial class frmRelatorioPeriodo : Form
    {
        public frmRelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            RelatorioDAO dao = new RelatorioDAO();

            List<RelatorioPeriodoVO> ListaRetorno = dao.EmitirPorPeriodo(txtDataInicial.Value, txtDataFinal.Value, Util.CodigoLogado);

            if (ListaRetorno.Count > 0)
            {
                frmResultadoPeriodoRel frm = new frmResultadoPeriodoRel();

                frm.CarregarRelatorio(ListaRetorno);

                frm.ShowDialog();
            }
            else
            {
                Util.ExibirMsgGeral(Util.TipoMsg.ConsultaSemRetorno);   
            }            
        }        
    }
}
