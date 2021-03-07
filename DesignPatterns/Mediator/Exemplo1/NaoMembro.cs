using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public class NaoMembro : Participante
    {
        public NaoMembro(string nome) : base(nome)
        {
        }

        public override void Receber(string mensagemDe, string mensagem)
        {
            Console.Write("Para nao membro: ");
            base.Receber(mensagemDe, mensagem);
        }
    }
}
