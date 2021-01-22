using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridges
{
    public interface IEnviador
    {
        void Envia(IMensagem mensagem);

    }
}
