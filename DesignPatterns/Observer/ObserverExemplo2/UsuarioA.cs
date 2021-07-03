using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ObserverExemplo2
{
    public class UsuarioA : IObserver<Email>
    {
        private IDisposable _disposer;

        public UsuarioA(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "A");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}
