using System;

namespace MatrizesFixacaoExercise {
    class Program {
        static void Main(string[] args) {

            string[] measures = Console.ReadLine().Split(' ');

            int n = int.Parse(measures[0]);
            int m = int.Parse(measures[1]);

            int[,] mat = new int[n,m];

            for(int i = 0; i < mat.GetLength(0); i++) {

                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < mat.GetLength(0); i++) {
                for(int j = 0; j < mat.GetLength(1); j++) {

                    if(mat[i,j] == num) {

                        Console.WriteLine("\n- Position "+ i + "," + j + ":");
                        if(j != 0) {
                            Console.WriteLine("Left: " + mat[i,(j-1)]);
                        }
                        if(j != (mat.GetLength(1) - 1)) {
                            Console.WriteLine("Right: " + mat[i,(j+1)]);
                        }
                        if(i != 0) {
                            Console.WriteLine("Up: " + mat[(i-1),j]);
                        }
                        if(i != (mat.GetLength(0) - 1)) {
                            Console.WriteLine("Down: " + mat[(i+1),j]);
                        }

                    }

                }
            }

        }
    }
}
