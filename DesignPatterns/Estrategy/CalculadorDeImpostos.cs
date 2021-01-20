using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
