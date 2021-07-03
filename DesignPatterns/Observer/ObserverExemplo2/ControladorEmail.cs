using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ObserverExemplo2
{
    public class ControladorEmail : IObservable<Email>
    {
        public List<IObserver<Email>> _usuarios;
        public Email _email;
        public ControladorEmail(Email email)
        {
            _usuarios = new List<IObserver<Email>>();
            _email = email;
        }

        public IDisposable Subscribe(IObserver<Email> usuario)
        {
            if (!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);

            return new Disposer(_usuarios, usuario);
        }

        public void EnviarEmail()
        {
            _email.Descricao = "Email Enviado para o usuário";

            foreach (IObserver<Email> usuario in _usuarios)
            {
                usuario.OnNext(_email);
            }
        }

    }
}
