using DesignPatterns.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public IList<Item> Itens { get; private set; }
        public double Valor { get; set; }


        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

    }
}
