using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public class ChatSala : IChatSalaMediator
    {

        private IDictionary<string, Participante> _participantes = new Dictionary<string, Participante>();

        public void Enviar(string mensagemDe, string para, string mensagem)
        {
            Participante participante = null;
            this._participantes.TryGetValue(para, out participante);
            if (participante != null)
            {
                participante.Receber(mensagemDe, mensagem);
            }
        }

        public void Registro(Participante participante)
        {
            if (!this._participantes.ContainsKey(participante.Nome))
            {
                _participantes.Add(participante.Nome, participante);
            }
            
            participante.ChatSala = this;
        }

    }
}
