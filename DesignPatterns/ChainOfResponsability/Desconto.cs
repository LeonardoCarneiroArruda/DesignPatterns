using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsability
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }

        double Desconta(Orcamento orcamento); 
    }
}
