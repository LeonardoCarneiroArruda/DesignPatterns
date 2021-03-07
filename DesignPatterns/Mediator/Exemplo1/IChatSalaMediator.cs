using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public interface IChatSalaMediator
    {
        void Registro(Participante participante);
        void Enviar(string mensagemDe, string para, string mensagem);
    }
}
