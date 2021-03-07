using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo2
{
    public class Jogador
    {
        public Guid ID { get; private set; }
        public string Nome { get; private set; }
        public int Numero { get; private set; }
        public bool EstaEmCampo { get; private set; }

        public Jogador(string nome, int numero, bool estaEmCampo)
        {
            ID = Guid.NewGuid();
            Nome = nome;
            Numero = numero;
            EstaEmCampo = estaEmCampo;
        }
        public void SaiDeCampo()
        {
            Console.WriteLine($"{this.Nome} está saindo de campo.");
            EstaEmCampo = false;
        }

        public void EntraEmCampo()
        {
            Console.WriteLine($"{this.Nome} está entrando no campo.");
            EstaEmCampo = true;
        }
    }
}
