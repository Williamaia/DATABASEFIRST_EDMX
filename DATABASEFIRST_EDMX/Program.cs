using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATABASEFIRST_EDMX.Model;

namespace DATABASEFIRST_EDMX
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DB_PRODUTOSEntities();

            Console.WriteLine("Digite o nome do produto:");
            string nomeproduto = Console.ReadLine();

            var _produto = new TB_PRODUTOS() {
                IDTIPOPRODUTO = 1,
                NOMEPRODUTO = nomeproduto,
                DESCRICAOPRODUTO = "teste teste teste...",
                DATACADASTRO = DateTime.Now
            };

            dbContext.TB_PRODUTOS.Add(_produto);
            dbContext.SaveChanges();


            var produtos = dbContext.TB_PRODUTOS.ToList();

            foreach (var produto in produtos)
            {
                Console.WriteLine("Nome produto: " + produto.NOMEPRODUTO);
            }

            Console.WriteLine("Working...");
            Console.ReadKey();
        }
    }
}
