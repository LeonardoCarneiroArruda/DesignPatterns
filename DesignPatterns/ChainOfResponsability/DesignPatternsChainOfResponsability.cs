using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsability
{
    public class DesignPatternsChainOfResponsability : IDesignPatterns
    {
        public void MainExemplo()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(600);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Item("BORRACHA", 250));
            orcamento.AdicionaItem(new Item("FOGAO", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
        }


    }
}
