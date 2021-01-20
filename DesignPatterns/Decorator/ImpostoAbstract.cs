using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class ImpostoAbstract
    {
        public ImpostoAbstract OutroImposto { get; set; }

        public ImpostoAbstract(ImpostoAbstract outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public ImpostoAbstract()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
