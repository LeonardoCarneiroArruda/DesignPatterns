using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class DesignPatternsMemento : IDesignPatterns
    {
        public void MainExemplo()
        {

            Historico historico = new Historico();
            Contrato contrato = new Contrato(DateTime.Now, "Leo", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
        }

    }
}
