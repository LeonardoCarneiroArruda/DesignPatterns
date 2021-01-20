using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf);

    }
}
