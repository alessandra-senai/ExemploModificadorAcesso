using System;

namespace ExemploAcessoPrivateProtected
{
    public class Zoologico : Animal
    {
        public string ZoologicoNome { get; set; }
        public string ZoologicoEndereco { get; set; }

        public string AnimalNome
        {
            get { return animalNome; }
            set { animalNome = value; }
        }

        public string AnimalFamilia {
            get { return animalFamilia; }
            set { animalFamilia = value;  }
        }

        public DateTime AnimalDataNascimento
        {
            get { return animalDataNascimento; }
            set { animalDataNascimento = value; }
        }

    }
}
