using System;

namespace MatrizesExercicios {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            //primeira dimensão - quantidade de linhas
            Console.WriteLine(mat.Rank);

            //primeira dimensão - quantidade de linhas
            Console.WriteLine(mat.GetLength(0));

            //segunda dimensão - quantidade de colunas
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
