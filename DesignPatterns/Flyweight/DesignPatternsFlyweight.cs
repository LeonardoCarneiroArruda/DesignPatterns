using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class DesignPatternsFlyweight
    {

        public void MainExemploDesignPatternsFlyweight()
        {
            NotasMusicais notasMusicais = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notasMusicais.Pega("do"),
                notasMusicais.Pega("re"),
                notasMusicais.Pega("mi"),
                notasMusicais.Pega("fa"),
                notasMusicais.Pega("fa"),
                notasMusicais.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
        }

    }
}
