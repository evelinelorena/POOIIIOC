using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao2
{
    public class Varejo : Empresa
    {
        private readonly bool EnviarNotificacaoWhatsApp;

        public Varejo(bool enviarNotificacaoWhatsApp)
        {
            EnviarNotificacaoWhatsApp = enviarNotificacaoWhatsApp;
        }

        public override void RealizarVenda()
        {
            Console.WriteLine("Vende Produtos");

            if (EnviarNotificacaoWhatsApp)
            {
                IEnviarNotificacao enviarNotificacao = new EnviarNotificacaoWhatsApp();
                enviarNotificacao.EnviarMensagemCliente();
            }
        }
    }
}
