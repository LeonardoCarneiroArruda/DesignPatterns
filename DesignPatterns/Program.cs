using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Facades;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesignPatterns designExemplo = new DesignPatternsFacade();
            designExemplo.MainExemplo();


            Console.ReadKey();

        }
    }
}
