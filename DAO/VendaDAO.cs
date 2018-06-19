using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendaDAO
    {
        public List<VendaVO> ConsultarVendas(int codEmpresa)
        {
            banco banco = new banco();

            List<VendaVO> ListaRetorno = new List<VendaVO>();

            List<tb_venda> ListaVendas = banco.tb_venda.Include("tb_veiculo.tb_modelo").Include("tb_cliente").Include("tb_vendedor_sistema").Where(p => p.tb_veiculo.cod_empresa == codEmpresa).ToList();

            int frm_pag = 0;

            for (int i = 0; i < ListaVendas.Count; i++)
            {
                VendaVO vo = new VendaVO();

                vo.cod_venda = ListaVendas[i].cod_venda;
                vo.cod_veiculo = ListaVendas[i].cod_veiculo;
                vo.cod_cliente = ListaVendas[i].cod_cliente;
                vo.cod_vendedor = ListaVendas[i].cod_vendedor;
                vo.data_venda = ListaVendas[i].data_venda.ToString();                
                vo.obs_venda = ListaVendas[i].observacao_venda;
                vo.nome_veiculo = ListaVendas[i].tb_veiculo.tb_modelo.nome_modelo;
                vo.nome_cliente = ListaVendas[i].tb_cliente.nome_cliente;
                vo.nome_vendedor = ListaVendas[i].tb_vendedor_sistema.nome_vendedor;
                frm_pag = ListaVendas[i].forma_pgto;

                switch (frm_pag)
                {
                    case 1 :
                        vo.forma_pagamento = "À vista";
                        break;
                    case 2 :
                        vo.forma_pagamento = "Boleto";
                        break;
                    case 3 :
                        vo.forma_pagamento = "Cartão parcelado";
                        break;
                    case 4 :
                        vo.forma_pagamento = "Cartão vencimento";
                        break;
                    case 5 :
                        vo.forma_pagamento = "Cartão débito";
                        break;
                }

                ListaRetorno.Add(vo);
            }

            return ListaRetorno;

        }
    }
}
