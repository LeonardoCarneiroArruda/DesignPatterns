using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set;}

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia() => Valor;

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
