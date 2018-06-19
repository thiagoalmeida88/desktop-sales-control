using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmpresaDAO
    {
        public tb_empresa ValidarLogin(string cnpj, string senha)
        {
            banco banco = new banco();

            tb_empresa empresa = banco.tb_empresa.FirstOrDefault(p => p.cnpj_empresa == cnpj && p.senha_empresa == senha);

            return empresa;

        }

    }
}
