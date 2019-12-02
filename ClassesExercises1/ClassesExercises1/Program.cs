using System;
using System.Globalization;

namespace ClassesExercises1 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Insira os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Qtd = int.Parse(Console.ReadLine());


            Console.WriteLine("\nDados do Produto: " + p);

            Console.Write("\nDigite o número de Produtos a serem adicionado no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine("\nDados do Atualizados: " + p);

            Console.Write("\nDigite o número de Produtos a serem removidos no estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine("\nDados do Atualizados: " + p);
        }
    }
}
