using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridges
{
    public class MensagemDoCliente : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemDoCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Mensagem para o cliente {nome}");
        }
    }
}
