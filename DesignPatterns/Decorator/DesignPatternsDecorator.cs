using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class DesignPatternsDecorator : IDesignPatterns
    {

        public void MainExemplo()
        {
            ImpostoAbstract iss = new ImpostoISS(new ImpostoICMS());

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
        }

    }
}
