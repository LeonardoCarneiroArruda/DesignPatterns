using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public interface IMediatorJogador
    {
        Task Send(SubstituirJogadorCommand handler);
    }
}
