using DesignPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Facades
{
    public class ClienteDAO
    {
        private List<Cliente> Clientes;

        public ClienteDAO()
        {
            Clientes = new List<Cliente>()
            {
                new Cliente("Leonardo", "123"),
                new Cliente("Luis", "456"),
                new Cliente("Joao", "789"),
            };
        }

        public Cliente BuscaPorCPF(string cpf)
        {
            return Clientes.FirstOrDefault(cliente => cliente.cpf == cpf);
        }
    }
}