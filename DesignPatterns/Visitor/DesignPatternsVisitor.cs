using DesignPatterns.Interpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class DesignPatternsVisitor : IDesignPatterns
    {

        public void MainExemplo()
        {
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

        }

    }
}
