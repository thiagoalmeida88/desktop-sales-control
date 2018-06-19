using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class VendaVO
    {
        public int cod_venda { get; set; }
        public int cod_veiculo { get; set; }
        public int cod_cliente { get; set; }
        public int cod_vendedor { get; set; }
        public string data_venda { get; set; }
        public string forma_pagamento { get; set; }
        public string obs_venda { get; set; }
        public string nome_veiculo { get; set; }
        public string nome_cliente { get; set; }
        public string nome_vendedor { get; set; }

    }
}
