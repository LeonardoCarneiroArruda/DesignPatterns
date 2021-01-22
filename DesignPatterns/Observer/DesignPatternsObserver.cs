using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class DesignPatternsObserver : IDesignPatterns
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

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDAO());
            criador.AdicionaAcao(new EnviadorDeSMS());

            NotaFiscal nf = criador.Constroi();

        }

    }
}
