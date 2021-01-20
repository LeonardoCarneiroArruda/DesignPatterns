using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens {get;set;}
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }

    }
}
