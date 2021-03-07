using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class Mediador : IMediatorJogador
     {
        private IHandler _handler;
        public Mediador(IHandler handler)
        {
            this._handler = handler;
        }

        public async Task Send(SubstituirJogadorCommand _command)
        {
            await _handler.Handle(_command);
        }
    }
}
