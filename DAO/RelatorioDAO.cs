using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RelatorioDAO
    {
        public List<RelatorioPeriodoVO> EmitirPorPeriodo(DateTime dataInicial, DateTime dataFinal, int codEmpresa)
        {

            banco banco = new banco();

            List<RelatorioPeriodoVO> ListaRetorno = new List<RelatorioPeriodoVO>();

            List<tb_venda> ListaConsulta = banco.tb_venda.Include("tb_veiculo.tb_modelo.tb_marca").Include("tb_vendedor_sistema").Include("tb_cliente").Where(p => p.data_venda >= dataInicial && p.data_venda <= dataFinal && p.tb_veiculo.cod_empresa == codEmpresa).ToList();

            for (int i = 0; i < ListaConsulta.Count; i++)
            {
                RelatorioPeriodoVO vo = new RelatorioPeriodoVO();

                vo.Cliente = ListaConsulta[i].tb_cliente.nome_cliente;
                vo.Marca = ListaConsulta[i].tb_veiculo.tb_modelo.tb_marca.nome_marca;
                vo.Modelo = ListaConsulta[i].tb_veiculo.tb_modelo.nome_modelo;
                vo.Vendedor = ListaConsulta[i].tb_vendedor_sistema.nome_vendedor;
                vo.Data = ListaConsulta[i].data_venda.ToShortDateString();
                vo.Valor = ListaConsulta[i].tb_veiculo.valor_venda;

                ListaRetorno.Add(vo);

            }

            return ListaRetorno;

        }

        public List<RelatorioVendedorVO> EmitirPorVendedor(int codVendedor)
        {
            banco banco = new banco();

            List<RelatorioVendedorVO> ListaRetorno = new List<RelatorioVendedorVO>();

            List<tb_venda> ListaConsulta = banco.tb_venda.Include("tb_veiculo.tb_modelo.tb_marca").Include("tb_vendedor_sistema").Include("tb_cliente").Where(p => p.cod_vendedor == codVendedor).ToList();

            for (int i = 0; i < ListaConsulta.Count; i++)
            {
                RelatorioVendedorVO vo = new RelatorioVendedorVO();
                                
                vo.Cliente = ListaConsulta[i].tb_cliente.nome_cliente;
                vo.Marca = ListaConsulta[i].tb_veiculo.tb_modelo.tb_marca.nome_marca;
                vo.Modelo = ListaConsulta[i].tb_veiculo.tb_modelo.nome_modelo;
                vo.Vendedor = ListaConsulta[i].tb_vendedor_sistema.nome_vendedor;
                vo.Data = ListaConsulta[i].data_venda.ToShortDateString();
                vo.Valor = ListaConsulta[i].tb_veiculo.valor_venda;

                ListaRetorno.Add(vo);

            }

            return ListaRetorno;
        }
    }
}
