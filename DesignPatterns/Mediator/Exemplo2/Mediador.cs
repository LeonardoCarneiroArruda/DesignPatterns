using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class Mediador : IMediator
     {
        private IRequestHandler _handler;
        public Mediador(IRequestHandler handler)
        {
            this._handler = handler;
        }

        public async Task Send(SubstituirJogadorCommand _command)
        {
            await _handler.Handle(_command);
        }
    }
}
