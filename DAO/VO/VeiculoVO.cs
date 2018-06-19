using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class VeiculoVO
    {
        public int codigo_veiculo { get; set; }
        public int codigo_modelo { get; set; }
        public int codigo_marca { get; set; }
        public int codigo_cor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string ano_fabricacao { get; set; }
        public string ano_veiculo { get; set; }
        public string km { get; set; }
        public string cor { get; set; }
        public string portas { get; set; }
        public int direcao { get; set; }
        public int airbag { get; set; }
        public bool ar { get; set; }
        public bool abs { get; set; }
        public Decimal valor_compra { get; set; }
        public Decimal valor_venda { get; set; }
        public int situacao { get; set; }
        public string obs { get; set; }

    }
}
