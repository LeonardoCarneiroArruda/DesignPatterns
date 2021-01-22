using DesignPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    public class EmpresaFacade
    {

        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCPF(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valorFatura)
        {
            return new Fatura(cliente, valorFatura);
        }

        public Cobranca GeraCobranca(TipoCobranca tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();

            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();

            return contato;
        }

    }
}
