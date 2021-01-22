using System;

namespace DesignPatterns.Facades
{
    public class Cobranca
    {
        public TipoCobranca Tipo { get; private set; }
        public Fatura Fatura { get; private set; }

        public Cobranca(TipoCobranca tipo, Fatura fatura)
        {
            this.Tipo = tipo;
            this.Fatura = fatura;
        }

        public void Emite()
        {
            Console.WriteLine($"Emitindo cobranca do tipo {Tipo}, no valor de {Fatura.Valor}, para o cliente {Fatura.Cliente.Nome}");
        }
    }
}