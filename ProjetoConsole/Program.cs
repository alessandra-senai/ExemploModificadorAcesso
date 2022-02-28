using ExemploAcessoInternal;
using ExemploAcessoPrivate;
using ExemploAcessoProtected;
using ExemploAcessoPublic;
using System;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Patricia Santos";
            pessoa.CPF = "456.543.55-09";
            pessoa.RG = "34.234.234-0";

            Console.WriteLine("--EXEMPLO MODIFICADOR DE ACESSO - PUBLIC ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Nome = {pessoa.Nome}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"CPF = {pessoa.CPF}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"RG = {pessoa.RG}");
            Console.WriteLine("--------------------------------------------");

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Carlos Silva";
            funcionario.NumeroRegistro = 45;
            funcionario.Endereco = "Rua Azul, 45 - Sorocaba";
            funcionario.Salario = 4560.54M;

            Console.WriteLine("--EXEMPLO MODIFICADOR DE ACESSO - PRIVATE ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Funcionário = {funcionario.Nome}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Número de Registro = {funcionario.NumeroRegistro}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Endereço = {funcionario.Endereco}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Salário = {funcionario.Salario}");
            Console.WriteLine("--------------------------------------------");

            Empresa empresa = new Empresa("ASS Programação", "45.543.555-0001-90",
                                "432.432.33", "Avenida Paulista, 100 - São Paulo",
                                new DateTime(1990, 04, 24));

            Console.WriteLine("--EXEMPLO MODIFICADOR DE ACESSO - PRIVATE ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Empresa = {empresa.RazaoSocial}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"CNPJ = {empresa.CNPJ}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Endereço = {empresa.Endereco}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Inscrição Estadual = {empresa.InscricaoEstadual}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Data de Criação = {empresa.DataCriacao}");
            Console.WriteLine("--------------------------------------------");

            OperacaoSoma operacaoSoma = new OperacaoSoma(5,4);
            Console.WriteLine("--EXEMPLO MODIFICADOR DE ACESSO - INTERNAL ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Resultado Soma = {operacaoSoma.ResultadoSoma}");
            Console.WriteLine("--------------------------------------------");


            ContaBancaria contaBancaria = new ContaBancaria();
            ContaCorrente contaCorrente = new ContaCorrente();
            
        }
    }
}
