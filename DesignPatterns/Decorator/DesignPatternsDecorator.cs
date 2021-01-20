using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class DesignPatternsDecorator
    {

        public void MainExemploDecorator()
        {
            ImpostoAbstract iss = new ImpostoISS(new ImpostoICMS());

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
        }

    }
}
