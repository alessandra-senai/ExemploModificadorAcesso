using ProjetoExemploA;
using ProjetoExemploB;
using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkItem item = new WorkItem("Exemplo de Modificador Acesso",
                            "Exemplo modificador acesso da classe WorkItem");

           
            ChangeRequest change = new ChangeRequest
                ("Modificador Acesso - ChangeRequest",
                 "Adicionando informações no modificador acesso",
                 1);

            
            Console.WriteLine(item.ReturnWorkItemInformation(item));

          
            change.Update("Título alterado");

            
            Console.WriteLine(change.ReturnChangeRequestInformation(change));
        }
    }
}
