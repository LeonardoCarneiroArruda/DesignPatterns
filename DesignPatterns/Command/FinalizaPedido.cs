using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class FinalizaPedido : ICommand
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {pedido.Cliente}");
            pedido.Finaliza();
        }
    }
}
