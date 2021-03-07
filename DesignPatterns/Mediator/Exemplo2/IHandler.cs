using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public interface IHandler
    {
        Task<IEnumerable<Jogador>> Handle(SubstituirJogadorCommand request);
    }
}