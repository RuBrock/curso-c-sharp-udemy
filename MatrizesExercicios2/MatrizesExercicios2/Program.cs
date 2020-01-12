using System;

namespace MatrizesExercicios2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < mat.GetLength(0); i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("\nMain diagonal:");
            string diagonal = "";
            for (int i = 0; i < n; i++) {

                if (diagonal.Equals("")) {
                    diagonal += mat[i, i];
                }
                else {
                    diagonal = diagonal + " => " + mat[i, i];
                }

            }
            Console.WriteLine(diagonal);

            Console.Write("Negative numbers = ");
            int countNeg = 0;
            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {

                    if (mat[i, j] < 0) {
                        countNeg++;
                    }

                }
            }
            Console.WriteLine(countNeg);


        }

    }
}
