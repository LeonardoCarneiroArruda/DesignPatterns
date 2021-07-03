using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ObserverExemplo2
{
    public class UsuarioB : IObserver<Email>
    {
        private IDisposable _disposer;
        public UsuarioB(IObservable<Email> controladorEmail)
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
            Console.WriteLine(value.Descricao + "B");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}
