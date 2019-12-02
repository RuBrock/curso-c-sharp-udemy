using System;
using System.Globalization;

namespace POOExercises {
    class Program {
        static void Main(string[] args) {


            Produto p = new Produto("TV", 899.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Qtd);
            /*
             * Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */

            /*
            Console.Write("Quantidade no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            */

            //Produto p = new Produto(nome, preco, qtd);

            /*
             * Produto p = new Produto(nome, preco);

            Console.WriteLine("\nDados do produto: " + p);
            
            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int quatidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quatidade);
            
            Console.WriteLine("Dados atualizados: " + p);
            
            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            quatidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quatidade);
            
            Console.WriteLine("Dados atualizados: " + p);
            */
        }
    }
}
