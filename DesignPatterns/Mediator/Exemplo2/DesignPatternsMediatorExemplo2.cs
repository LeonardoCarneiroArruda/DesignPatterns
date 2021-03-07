using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class DesignPatternsMediatorExemplo2 : IDesignPatterns
    {
        public void MainExemplo()
        {
            Tecnico tecnico = new Tecnico("Falcao");
            QuartoArbitro quartoArbitro = new QuartoArbitro("QuartoArbitro");
            Jogador jogadorQueSai = new Jogador("Pele", 10, true);
            Jogador jogadorQueEntra = new Jogador("Maradona", 11, false);

            IMediator mediador = new Mediador(new SubstituirJogadorCommandHandler());
            mediador.Send(new SubstituirJogadorCommand(tecnico, jogadorQueSai, jogadorQueEntra, quartoArbitro));

        }
    }
}
