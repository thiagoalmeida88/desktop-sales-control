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
    public partial class frmResultadoVendedorRel : Form
    {
        public frmResultadoVendedorRel()
        {
            InitializeComponent();
        }

        private void frmRelatorioVendedorRel_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void CarregarRelatorio(List<RelatorioVendedorVO> lst)
        {
            RelatorioVendedorVOBindingSource.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
