using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato) 
        {
            this.Contrato = contrato;
        }

    }
}
