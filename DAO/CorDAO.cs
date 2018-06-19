using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CorDAO
    {
        public void InserirCor(tb_cor objEntrada)
        {
            banco banco = new banco();

            banco.AddTotb_cor(objEntrada);
            banco.SaveChanges();
        }

        public void AlterarCor(tb_cor objentrada)
        {
            banco banco = new banco();

            tb_cor objAtualizar = banco.tb_cor.FirstOrDefault(p => p.cod_cor == objentrada.cod_cor);

            objAtualizar.nome_cor = objentrada.nome_cor;

            banco.SaveChanges();
        }

        public List<tb_cor> ConsultarCor(int codLogado)
        {
            banco banco = new banco();

            List<tb_cor> ListaConsulta = banco.tb_cor.Where(p => p.cod_empresa == codLogado).ToList();

            return ListaConsulta;
        }
    }
}
