using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string cpf { get; set; }

        public string Endereco { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf) 
        {
            this.Nome = nome;
            this.cpf = cpf;
        }

    }
}
