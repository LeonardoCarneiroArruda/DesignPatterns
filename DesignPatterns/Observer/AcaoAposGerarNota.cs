using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);

    }
}
