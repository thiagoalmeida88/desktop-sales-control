using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ModeloDAO
    {
        public void InserirModelo(tb_modelo objEntrada)
        {
            banco banco = new banco();

            banco.AddTotb_modelo(objEntrada);
            banco.SaveChanges();
        }

        public void AlterarModelo(tb_modelo objEntrada)
        {
            banco banco = new banco();

            tb_modelo objAtualizar = banco.tb_modelo.FirstOrDefault(p => p.cod_modelo == objEntrada.cod_modelo);

            objAtualizar.nome_modelo = objEntrada.nome_modelo;
            objAtualizar.cod_marca = objEntrada.cod_marca;
            banco.SaveChanges();
        }

        public List<tb_modelo> FiltrarModelo(int codMarca)
        {
            banco banco = new banco();

            List<tb_modelo> Lista = banco.tb_modelo.Where(p => p.cod_marca == codMarca).ToList();

            return Lista;
        }

        public List<ModeloVO> ConsultarModelos(int codEmpresa)
        {
            banco banco = new banco();

            List<ModeloVO> ListaRetorno = new List<ModeloVO>();

            List<tb_modelo> ListaModelos = banco.tb_modelo.Include("tb_marca").Where(p => p.cod_empresa == codEmpresa).OrderBy(p=>p.nome_modelo).ToList();

            for (int i = 0; i < ListaModelos.Count; i++)
            {
                ModeloVO vo = new ModeloVO();

                vo.codigo_modelo = ListaModelos[i].cod_modelo;
                vo.codigo_marca = ListaModelos[i].tb_marca.cod_marca;
                vo.marca = ListaModelos[i].tb_marca.nome_marca;
                vo.modelo = ListaModelos[i].nome_modelo;

                ListaRetorno.Add(vo);

            }
            
            return ListaRetorno;

        }
    }
}
