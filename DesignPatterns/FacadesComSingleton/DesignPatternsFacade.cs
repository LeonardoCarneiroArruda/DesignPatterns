using DesignPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    public class DesignPatternsFacade : IDesignPatterns
    {
        public void MainExemplo()
        {
            string cpf = "789";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 125);
            var cobranca = facade.GeraCobranca(TipoCobranca.Cartao, fatura);
            facade.FazContato(cliente, cobranca);
        }
    }
}
