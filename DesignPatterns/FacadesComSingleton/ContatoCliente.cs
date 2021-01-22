using System;
using DesignPatterns.Adapter;

namespace DesignPatterns.Facades
{
    public class ContatoCliente
    {
        public Cliente Cliente { get; private set; }
        public Cobranca Cobranca { get; private set; }

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.Cliente = cliente;
            this.Cobranca = cobranca;
        }

        public void Dispara()
        {
            Console.WriteLine($"Disparando contato com o cliente {Cliente.Nome}, para falar sobre a fatura do tipo {Cobranca.Tipo}");
        }
    }
}