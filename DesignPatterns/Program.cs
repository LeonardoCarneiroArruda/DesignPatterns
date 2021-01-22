using DesignPatterns.Command;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesignPatterns designExemplo = new DesignPatternsCommand();
            designExemplo.MainExemplo();


            Console.ReadKey();

        }
    }
}
