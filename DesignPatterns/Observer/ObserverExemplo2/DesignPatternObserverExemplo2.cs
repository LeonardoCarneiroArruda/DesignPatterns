using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ObserverExemplo2
{
    public class DesignPatternObserverExemplo2 : IDesignPatterns
    {
        public void MainExemplo()
        {
            var email = new Email();

            var controladorEmail = new ControladorEmail(email);

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");
         
            var usuarioA = new UsuarioA(controladorEmail);
            var usuarioB = new UsuarioB(controladorEmail);
            var usuarioC = new UsuarioC(controladorEmail);

            Console.WriteLine("Enviando os emails para os usuários assinados (usuários cadastrados).\n");
         
            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu cancelar a assinatura e não irá receber mais emails.\n");
         
            usuarioA.Dispose();

            Console.WriteLine("Enviando os emails para os usuários assinados.\n");
         
            controladorEmail.EnviarEmail();

        }
    }
}
