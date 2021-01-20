using DesignPatterns.ChainOfResponsability;
using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => (orcamento.Valor > 500 && temItemMaiorQue100Reas(orcamento));

        public override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.10;

        public override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.06;

        private bool temItemMaiorQue100Reas(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
