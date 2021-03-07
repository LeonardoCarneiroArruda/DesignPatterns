using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public interface IMediator
    {
        Task Send(SubstituirJogadorCommand handler);
    }
}
