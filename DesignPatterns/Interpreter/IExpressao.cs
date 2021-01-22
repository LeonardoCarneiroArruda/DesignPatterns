using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public interface IExpressao
    {
        int Avalia();

        void Aceita(IVisitor impressora);
    }
}
