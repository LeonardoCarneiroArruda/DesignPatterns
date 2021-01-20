using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ImpostoISS : ImpostoAbstract
    {
        public ImpostoISS(ImpostoAbstract outroImposto) : base(outroImposto)
        {

        }

        public ImpostoISS() { }

        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);

       
    }
}
