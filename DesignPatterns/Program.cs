using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsability;
using DesignPatterns.Decorator;
using DesignPatterns.Estrategy;
using DesignPatterns.Factory;
using DesignPatterns.Flyweight;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.TemplateMethod;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            new DesignPatternsMemento().MainExemploDesignPatternsMemento();


            Console.ReadKey();

        }
    }
}
