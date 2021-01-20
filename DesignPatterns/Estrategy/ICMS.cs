using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1;

    }
}
