using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAcessoInternal
{
    internal class Calculadora
    {
        internal int CalcularSoma(int numeroA, int numeroB)
        {
            return numeroA + numeroB;
        }

        internal int CalcularSubtracao(int numeroA, int numeroB)
        {
            return numeroA - numeroB;
        }
        internal int CalcularMultiplicacao(int numeroA, int numeroB)
        {
            return numeroA * numeroB;
        }
        internal int CalcularDivisao(int numeroA, int numeroB)
        {
            return numeroA * numeroB;
        }
    }
}
