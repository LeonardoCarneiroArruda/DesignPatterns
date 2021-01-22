using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class DesignPatternsBuilder : IDesignPatterns
    {
        public void MainExemplo()
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("Empresa de fachada")
                   .ComCnpj("00000000000000")
                   .ComItem(new ItemDaNota("Item 1", 150))
                   .ComItem(new ItemDaNota("Item 2", 50))
                   .NaDataAtual()
                   .ComObservacoes("observacao qualquer");

            NotaFiscal nf = criador.Constroi();
            Console.Write(nf.ValorBruto);
        }

    }
}
