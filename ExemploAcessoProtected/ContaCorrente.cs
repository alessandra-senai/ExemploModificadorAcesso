using ExemploAcessoInternal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAcessoProtected
{
    public class ContaCorrente : ContaBancaria
    {
        public string ContaNumero
        {
            get { return contaNumero; }
            set { contaNumero = value; }
        }
        public string ContaDigito
        {
            get { return contaDigito; }
            set { contaNumero = value; }
        }
        public string NomeTitular
        {
            get { return nomeTitular; }
            set { contaNumero = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public decimal SomarDeposito(decimal valorDeposito)
        {
            SomarValores somarValores = new SomarValores();

           var resultado = somarValores.SomaValoresDecimal(Saldo , valorDeposito);

            return resultado;
        }
    }
}
