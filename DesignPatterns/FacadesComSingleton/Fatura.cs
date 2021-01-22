using DesignPatterns.Adapter;

namespace DesignPatterns.Facades
{
    public class Fatura
    {
        public Cliente Cliente { get; private set; }
        public double Valor { get; private set; }

        public Fatura(Cliente cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
        }
    }
}