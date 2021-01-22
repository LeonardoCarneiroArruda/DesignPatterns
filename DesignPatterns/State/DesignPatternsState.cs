using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class DesignPatternsState : IDesignPatterns
    {
        public void MainExemplo()
        {
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);


            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
        }


    }
}
