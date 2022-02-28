using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAcessoPrivate
{
    public class Empresa
    {
       public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public Empresa(string razaoSocial, string cnpj, string inscricaoEstadual,
                        string endereco, DateTime dataCriacao) 
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            Endereco = endereco;
            DataCriacao = dataCriacao;
        }
    }
}
