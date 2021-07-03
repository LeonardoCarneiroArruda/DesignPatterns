using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ObserverExemplo2
{
    public class Disposer : IDisposable
    {
        private List<IObserver<Email>> _usuarios;
        private IObserver<Email> _usuario;

        public Disposer(List<IObserver<Email>> usuarios,
        IObserver<Email> usuario)
        {
            _usuarios = usuarios;
            _usuario = usuario;
        }

        public void Dispose()
        {
            if (_usuarios.Contains(_usuario))
                _usuarios.Remove(_usuario);
        }
    }
}
