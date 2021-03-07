using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class SubstituirJogadorCommandHandler : IRequestHandler
    {
        
        public Task<IEnumerable<Jogador>> Handle(SubstituirJogadorCommand request)
        {
            
            request.Tecnico.PedeSubstituicao(request.JogadorNoBanco.Nome, request.JogadorEmCampo.Nome);
            request.QuartoArbitro.LevantaPlaca(request.JogadorNoBanco.Numero, request.JogadorEmCampo.Numero);
            return Task.FromResult(
                SubstituiJogador(
                    request.Tecnico.Time,
                    request.JogadorNoBanco.Nome,
                    request.JogadorEmCampo.Nome
                )
            );
        }

        private IEnumerable<Jogador> SubstituiJogador(IEnumerable<Jogador> time, string nomeJogadorQueEntra, string nomeJogadorQueSai)
        {
            var timeAposSaida = JogadorSaiDeCampo(time, nomeJogadorQueSai);
            return JogadorEntraEmCampo(timeAposSaida, nomeJogadorQueEntra);
        }

        private IEnumerable<Jogador> JogadorEntraEmCampo(IEnumerable<Jogador> time, string nome)
        {
            foreach (var jogador in time)
            {
                if (jogador.Nome == nome)
                {
                    jogador.EntraEmCampo();
                    yield return jogador;
                }
                yield return jogador;
            }
        }

        private IEnumerable<Jogador> JogadorSaiDeCampo(IEnumerable<Jogador> time, string nome)
        {
            foreach (var jogador in time)
            {
                if (jogador.Nome == nome)
                {
                    jogador.SaiDeCampo();
                    yield return jogador;
                }
                yield return jogador;
            }
        }

        
    }
}
