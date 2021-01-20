using DesignPatterns.Builder;
using DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {

        /*Exemplo caro de uma FLUENT INTERFACE*/


        public string RazaoSoial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        //Meu Observer
        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSoial = razaoSocial;

            return this;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            this.Observacoes = obs;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;

            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSoial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
                acao.Executa(nf);


            return nf;
        }

    }
}
