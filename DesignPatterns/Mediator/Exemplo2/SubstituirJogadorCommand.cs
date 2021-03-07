using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class SubstituirJogadorCommand
    {
        public Tecnico Tecnico { get; private set; }
        public Jogador JogadorEmCampo { get; private set; }
        public Jogador JogadorNoBanco { get; private set; }
        public QuartoArbitro QuartoArbitro { get; private set; }

        public SubstituirJogadorCommand(
            Tecnico tecnico,
            Jogador jogadorEmCampo,
            Jogador jogadorNoBanco,
            QuartoArbitro quartoArbitro
        )
        {
            Tecnico = tecnico;
            JogadorEmCampo = jogadorEmCampo;
            JogadorNoBanco = jogadorNoBanco;
            QuartoArbitro = quartoArbitro;
        }

    }
}
