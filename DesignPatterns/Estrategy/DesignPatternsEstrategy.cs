using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public class DesignPatternsEstrategy : IDesignPatterns
    {

        public void MainExemplo()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);

        }

    }
}
