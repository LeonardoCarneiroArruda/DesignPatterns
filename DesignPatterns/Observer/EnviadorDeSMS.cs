using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class EnviadorDeSMS : AcaoAposGerarNota
    {

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("enviando por sms....");
        }
    }
}
