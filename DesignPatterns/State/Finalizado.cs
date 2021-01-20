using DesignPatterns.Estrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento finalizado nao aplicam desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception();
        }
    }
}
