using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeiculoDAO
    {
        public void InserirVeiculo(tb_veiculo objEntrada)
        {
            banco banco = new banco();

            banco.AddTotb_veiculo(objEntrada);
            banco.SaveChanges();
        }

        public void AlterarVeiculo(tb_veiculo objEntrada)
        {
            banco banco = new banco();

            tb_veiculo objAtualizar = banco.tb_veiculo.FirstOrDefault(p => p.cod_veiculo == objEntrada.cod_veiculo);

            objAtualizar.airbag_veiculo = objEntrada.airbag_veiculo;
            objAtualizar.ano_carro = objEntrada.ano_carro;
            objAtualizar.ano_fabricacao = objEntrada.ano_fabricacao;
            objAtualizar.ar_condicionado = objEntrada.ar_condicionado;
            objAtualizar.cod_cor = objEntrada.cod_cor;
            objAtualizar.cod_empresa = objEntrada.cod_empresa;
            objAtualizar.cod_modelo = objEntrada.cod_modelo;
            objAtualizar.direcao_veiculo = objEntrada.direcao_veiculo;
            objAtualizar.freio_abs = objEntrada.freio_abs;
            objAtualizar.km_veiculo = objEntrada.km_veiculo;
            objAtualizar.num_porta = objEntrada.num_porta;
            objAtualizar.obs_veiculo = objEntrada.obs_veiculo;
            objAtualizar.placa_veiculo = objEntrada.placa_veiculo;
            objAtualizar.situacao_veiculo = objEntrada.situacao_veiculo;
            objAtualizar.valor_compra = objEntrada.valor_compra;
            objAtualizar.valor_venda = objEntrada.valor_venda;

            banco.SaveChanges();

        }

        public List<VeiculoVO> ConsultarVeiculo(string placa, int codEmpresa)
        {
            banco banco = new banco();

            List<VeiculoVO> ListaRetorno = new List<VeiculoVO>();

            List<tb_veiculo> ListaConsulta = banco.tb_veiculo
                .Include("tb_cor").Include("tb_modelo.tb_marca")
                .Where(p => p.placa_veiculo.Contains(placa) && p.cod_empresa == codEmpresa).ToList();

            for (int i = 0; i < ListaConsulta.Count; i++)
            {
                VeiculoVO vo = new VeiculoVO();

                vo.placa = ListaConsulta[i].placa_veiculo;
                vo.airbag = ListaConsulta[i].airbag_veiculo;
                vo.ano_fabricacao = ListaConsulta[i].ano_fabricacao;
                vo.ano_veiculo = ListaConsulta[i].ano_fabricacao;
                vo.ar = ListaConsulta[i].ar_condicionado;
                vo.cor = ListaConsulta[i].tb_cor.nome_cor;
                vo.direcao = ListaConsulta[i].direcao_veiculo;
                vo.abs = ListaConsulta[i].freio_abs;
                vo.km = ListaConsulta[i].km_veiculo;
                vo.marca = ListaConsulta[i].tb_modelo.tb_marca.nome_marca;
                vo.modelo = ListaConsulta[i].tb_modelo.nome_modelo;
                vo.portas = ListaConsulta[i].num_porta;
                vo.obs = ListaConsulta[i].obs_veiculo;
                vo.situacao = ListaConsulta[i].situacao_veiculo;
                vo.valor_compra = ListaConsulta[i].valor_compra;
                vo.valor_venda = ListaConsulta[i].valor_venda;
                vo.codigo_veiculo = ListaConsulta[i].cod_veiculo;
                vo.codigo_cor = ListaConsulta[i].cod_cor;
                vo.codigo_marca = ListaConsulta[i].tb_modelo.cod_marca;
                vo.codigo_modelo = ListaConsulta[i].tb_modelo.cod_modelo;

                ListaRetorno.Add(vo);
            }

            return ListaRetorno;
        }
    }
}
