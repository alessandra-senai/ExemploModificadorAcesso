using ExemploAcessoInternal;
using ExemploAcessoPrivate;
using ExemploAcessoPrivateProtected;
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
 
            OperacaoSoma operacaoSoma = new OperacaoSoma(34, 43);
            Console.WriteLine("--Exemplo Modificador Acesso - Internal--------------");
            Console.WriteLine($"Operação Soma - ValorA = {operacaoSoma.ValorA}");
            Console.WriteLine($"Operação Soma - ValorB = {operacaoSoma.ValorB}");
            Console.WriteLine($"Operação Soma - Resultado = {operacaoSoma.ResultadoSoma}");
            Console.WriteLine("------------------------------------------------------------");


            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.ContaNumero = "4322";
            contaCorrente.ContaDigito = "4";
            contaCorrente.NomeTitular = "Carla Maria";
            contaCorrente.Saldo = 6789.65M;

            decimal resultado = contaCorrente.SomarDeposito(10000.00M);

            Console.WriteLine("--Exemplo Modificador Acesso - Protected--------------");
            Console.WriteLine($"Conta-Corrente número = {contaCorrente.ContaNumero} - dígito = {contaCorrente.ContaDigito} - Nome Titular = {contaCorrente.NomeTitular}");
            Console.WriteLine($"Saldo da conta corrente = {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo total da conta corrente = {resultado}");
            Console.WriteLine("-----------------------------------------------------------");

            Zoologico zoologico = new Zoologico();

            zoologico.ZoologicoNome = "Zoológico Municipal São Paulo";
            zoologico.ZoologicoEndereco = "Av. Cursino, 456 - São Paulo";
            zoologico.AnimalNome = "macaco";
            zoologico.AnimalFamilia = "mamífero";
            zoologico.AnimalDataNascimento = new DateTime(1990, 04, 25);

            Console.WriteLine("--Exemplo Modificador Acesso - Private Protected--------------");
            Console.WriteLine($"Zoológico Nome = {zoologico.ZoologicoNome}");
            Console.WriteLine($"Zoológico Endereço = {zoologico.ZoologicoEndereco}");
            Console.WriteLine($"Zoológico Nome Animal = {zoologico.AnimalNome}");
            Console.WriteLine($"Zoológico Animal Família = {zoologico.AnimalFamilia}");
            Console.WriteLine($"Zoológico Animal Data Nascimento = {zoologico.AnimalDataNascimento}");
        }
    }
}
