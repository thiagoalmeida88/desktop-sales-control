using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    public static class Util
    {
        public static int CodigoLogado; 

        public enum TipoMsg{
            Sucesso,
            Erro, 
            ConsultaSemRetorno,
            UsuarioNaoEncontrado
        }

        public static void ExibirMsgGeral(TipoMsg tipo)
        {
            if(tipo.ToString() == TipoMsg.Sucesso.ToString())
            {
                MessageBox.Show(Mensagens.Msg.MsgGravadoSucesso, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tipo.ToString() == TipoMsg.Erro.ToString())
            {
                MessageBox.Show(Mensagens.Msg.MsgErroGeral, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tipo.ToString() == TipoMsg.ConsultaSemRetorno.ToString())
            {
                MessageBox.Show(Mensagens.Msg.MsgConsultaSemDados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tipo.ToString() == TipoMsg.UsuarioNaoEncontrado.ToString())
            {
                MessageBox.Show(Mensagens.Msg.MsgUsuarioNaoEncontrado, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ExibirMsgValidacao(string campos)
        {
            MessageBox.Show(campos, Mensagens.Msg.MsgCamposObrigatorios, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
        }         
    }    
}
