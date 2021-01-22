using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    public class DesignPatternsAdapter : IDesignPatterns
    {
        public void MainExemplo()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Leonardo";
            cliente.Endereco = "Rua centro sobral";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXML().GeraXML(cliente);

            Console.WriteLine(xml);
        }
    }
}
