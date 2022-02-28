using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAcessoInternal
{
    public class OperacaoSoma
    {
        public int ValorA { get; private set; }
        public int ValorB { get; private set; }

        public int ResultadoSoma { get; private set; }

        public OperacaoSoma(int valorA, int valorB)
        {
            ValorA = valorA;
            ValorB = valorB;

            Calculadora calculadora = new Calculadora();
            ResultadoSoma = calculadora.CalcularSoma(valorA, valorB);
        }         
    }
}
