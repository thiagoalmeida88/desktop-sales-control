using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MarcaDAO
    {

        public void InserirMarca(tb_marca objEntrada)
        {
            banco banco = new banco();

            banco.AddTotb_marca(objEntrada);
            banco.SaveChanges();
        }
        public void AlterarMarca(tb_marca objEntrada)
        {
            banco banco = new banco();

            tb_marca objAtualizar = banco.tb_marca.FirstOrDefault(p => p.cod_marca == objEntrada.cod_marca);

            objAtualizar.nome_marca = objEntrada.nome_marca;
            banco.SaveChanges();

        }

        public List<tb_marca> ConsultarMarcas(int codEmpresa)
        {
            banco banco = new banco();

            List<tb_marca> ListaMarcas = banco.tb_marca.Where(p => p.cod_empresa == codEmpresa).OrderBy(p=>p.nome_marca).ToList();

            return ListaMarcas;
        }

    }
}
