using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridges
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();
        string Formata();

    }
}
