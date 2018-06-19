using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendedorDAO
    {
        public void InserirVendedor(tb_vendedor_sistema objEntrada)
        {
            banco banco = new banco();

            banco.AddTotb_vendedor_sistema(objEntrada);
            banco.SaveChanges();
        }

        public void AlterarVendedor(tb_vendedor_sistema objEntrada)
        {
            banco banco = new banco();

            tb_vendedor_sistema objAtualizar = banco.tb_vendedor_sistema.FirstOrDefault(p => p.cod_vendedor == objEntrada.cod_vendedor);

            objAtualizar.nome_vendedor = objEntrada.nome_vendedor;
            objAtualizar.email_vendedor = objEntrada.email_vendedor;
            objAtualizar.endereco_vendedor = objEntrada.endereco_vendedor;
            objAtualizar.celular_vendedor = objEntrada.celular_vendedor;
            objAtualizar.senha_vendedor = objEntrada.celular_vendedor;
            objAtualizar.status_vendedor = objEntrada.status_vendedor;
            banco.SaveChanges();
        }

        public List<VendedorVO> PesquisarVendedor(int codigoLogado, string txtDigitado, string opcaoEscolhida)
        {
            banco banco = new banco();

            List<VendedorVO> FiltroRetorno = new List<VendedorVO>();            

            List<tb_vendedor_sistema> FiltroVendedor = banco.tb_vendedor_sistema.Where(p => p.cod_empresa == codigoLogado 
                                                                                            && p.nome_vendedor.Contains(txtDigitado)).ToList();

            List<tb_vendedor_sistema> FiltroEmail = banco.tb_vendedor_sistema.Where(p => p.cod_empresa == codigoLogado
                                                                                            && p.email_vendedor.Contains(txtDigitado)).ToList();

            List<tb_vendedor_sistema> FiltroCelular = banco.tb_vendedor_sistema.Where(p => p.cod_empresa == codigoLogado
                                                                                            && p.celular_vendedor.Contains(txtDigitado)).ToList();

            if(opcaoEscolhida == "rdoVendedor")
            {
                for (int i = 0; i < FiltroVendedor.Count; i++)
                {
                    VendedorVO vo = new VendedorVO();

                    vo.codigo_vendedor = FiltroVendedor[i].cod_vendedor;
                    vo.vendedor = FiltroVendedor[i].nome_vendedor;
                    vo.email = FiltroVendedor[i].email_vendedor;
                    vo.endereco = FiltroVendedor[i].endereco_vendedor;                   
                    vo.celular = UtilDAO.TratarTelefoneTela(FiltroVendedor[i].celular_vendedor);
                    vo.status = FiltroVendedor[i].status_vendedor.ToString();


                    if (vo.status == "True")
                    {
                        vo.status = "Ativo";
                    }
                    else
                    {
                        vo.status = "Inativo";
                    }

                    vo.senha = FiltroVendedor[i].senha_vendedor;
                    FiltroRetorno.Add(vo);
                }
            }
            else if (opcaoEscolhida == "rdoEmail")
            {
                for (int i = 0; i < FiltroEmail.Count; i++)
                {
                    VendedorVO vo = new VendedorVO();

                    vo.codigo_vendedor = FiltroEmail[i].cod_vendedor;
                    vo.vendedor = FiltroEmail[i].nome_vendedor;
                    vo.email = FiltroEmail[i].email_vendedor;
                    vo.endereco = FiltroEmail[i].endereco_vendedor;                    
                    vo.celular = UtilDAO.TratarTelefoneTela(FiltroEmail[i].celular_vendedor);
                    vo.status = FiltroEmail[i].status_vendedor.ToString();


                    if (vo.status == "True")
                    {
                        vo.status = "Ativo";
                    }
                    else
                    {
                        vo.status = "Inativo";
                    }

                    vo.senha = FiltroEmail[i].senha_vendedor;
                    FiltroRetorno.Add(vo);
                }
            }
            else
            {
                for (int i = 0; i < FiltroCelular.Count; i++)
                {
                    VendedorVO vo = new VendedorVO();

                    vo.codigo_vendedor = FiltroCelular[i].cod_vendedor;
                    vo.vendedor = FiltroCelular[i].nome_vendedor;
                    vo.email = FiltroCelular[i].email_vendedor;
                    vo.endereco = FiltroCelular[i].endereco_vendedor;                    
                    vo.celular = UtilDAO.TratarTelefoneTela(FiltroCelular[i].celular_vendedor);
                    vo.status = FiltroCelular[i].status_vendedor.ToString();


                    if (vo.status == "True")
                    {
                        vo.status = "Ativo";
                    }
                    else
                    {
                        vo.status = "Inativo";
                    }

                    vo.senha = FiltroCelular[i].senha_vendedor;
                    FiltroRetorno.Add(vo);
                }
            }           
                 
            return FiltroRetorno;
        }

        public List<VendedorVO> ConsultarVendedor(int codEmpresa)
        {
            banco banco = new banco();

            List<VendedorVO> ListaRetorno = new List<VendedorVO>();

            List<tb_vendedor_sistema> ListaVendedor = banco.tb_vendedor_sistema.Where(p => p.cod_empresa == codEmpresa).OrderBy(p => p.nome_vendedor).ToList();

            for (int i = 0; i < ListaVendedor.Count; i++)
            {
                VendedorVO vo = new VendedorVO();

                vo.codigo_vendedor = ListaVendedor[i].cod_vendedor;
                vo.vendedor = ListaVendedor[i].nome_vendedor;
                vo.email = ListaVendedor[i].email_vendedor;
                vo.endereco = ListaVendedor[i].endereco_vendedor;
                vo.celular = UtilDAO.TratarTelefoneTela(ListaVendedor[i].celular_vendedor);
                vo.status = ListaVendedor[i].status_vendedor.ToString();
                

                if (vo.status == "True")
                {
                    vo.status = "Ativo";                   
                }
                else
                {
                    vo.status = "Inativo";
                }

                vo.senha = ListaVendedor[i].senha_vendedor;
                ListaRetorno.Add(vo);
            }

            return ListaRetorno;

        }

        public List<tb_vendedor_sistema> ConsultarVendedores(int codEmpresa)
        {
            banco banco = new banco();            

            List<tb_vendedor_sistema> ListaVendedor = banco.tb_vendedor_sistema.Where(p => p.cod_empresa == codEmpresa).OrderBy(p => p.nome_vendedor).ToList();
                        
            return ListaVendedor;

        }
    }
}
