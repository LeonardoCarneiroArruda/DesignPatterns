using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas = 
            new Dictionary<string, INota>() 
            {
                {"do", new Do() },
                {"re", new Re() },
                {"mi", new Mi() },
                {"fa", new Fa() }
            };


        public INota Pega(string nota)
        {
            return notas[nota];
        }

    }
}
