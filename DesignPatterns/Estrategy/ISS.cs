using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public class ISS : Imposto
    {

        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
    }
}
