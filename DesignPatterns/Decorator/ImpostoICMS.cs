using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ImpostoICMS : ImpostoAbstract
    {

        public ImpostoICMS(ImpostoAbstract outroImposto) : base(outroImposto) { }

        public ImpostoICMS() { }

        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
    }
}
