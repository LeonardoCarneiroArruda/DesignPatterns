using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class FilaDeTrabalho
    {
        private IList<ICommand> Comandos = new List<ICommand>();

        public void Adiciona(ICommand comando )
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in Comandos)
                comando.Executa();
        }




    }
}
