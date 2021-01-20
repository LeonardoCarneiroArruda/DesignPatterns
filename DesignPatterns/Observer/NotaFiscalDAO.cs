using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class NotaFiscalDAO : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("salvando no banco...");
        }
    }
}
