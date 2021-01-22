using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class DesignPatternsTemplateMethod : IDesignPatterns
    {

        public void MainExemplo()
        {
            var calculador = new CalculadorDeImpostos();
            Orcamento orcamento = new Orcamento(680);

            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();

           calculador.RealizaCalculo(orcamento, icpp);
           calculador.RealizaCalculo(orcamento, ikcv);

        }
    }
}
