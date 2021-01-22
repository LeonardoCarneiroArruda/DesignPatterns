using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class DesignPatternsCommand : IDesignPatterns
    {
        public void MainExemplo()
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();

            Pedido pedido1 = new Pedido("Mauricio", 100);
            Pedido pedido2 = new Pedido("Marcelo", 200);

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

        }
    }
}
