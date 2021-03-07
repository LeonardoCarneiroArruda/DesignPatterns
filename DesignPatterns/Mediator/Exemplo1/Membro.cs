using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public class Membro : Participante
    {
        public Membro(string nome) : base(nome)
        {
        }

        public override void Receber(string mensagemDe, string mensagem)
        {
            Console.Write("para Membro: ");
            base.Receber(mensagemDe, mensagem);
        }
    }
}
