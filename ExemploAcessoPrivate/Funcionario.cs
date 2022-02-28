namespace ExemploAcessoPrivate
{
    public class Funcionario
    {
        private int numeroRegistro { get; set; }
        private string nome { get; set; }
        private decimal salario { get; set; }
        private string endereco { get; set; }

        public int NumeroRegistro
        {
            get { return numeroRegistro; }
            set { numeroRegistro = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
                
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
