using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridges
{
    public class DesignPatternsBridges : IDesignPatterns
    {
        public void MainExemplo()
        {
            IMensagem mensagem = new MensagemAdministrativa("victor");
            IEnviador enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }
    }
}
