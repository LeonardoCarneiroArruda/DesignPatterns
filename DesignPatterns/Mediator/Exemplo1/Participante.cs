using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public class Participante
    {
        public IChatSalaMediator ChatSala { get; set; }
        public string Nome { get; private set; }

        public Participante(string nome)
        {
            Nome = nome;
        }

        public void Enviar(string para, string mensagem)
        {
            ChatSala.Enviar(this.Nome, para, mensagem);
        }

        public virtual void Receber(string mensagemDe, string mensagem)
        {
            Console.WriteLine($"{mensagemDe} para {this.Nome}: {mensagem}");
        }

    }
}
