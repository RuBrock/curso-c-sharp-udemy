using System;
using System.Collections.Generic;

namespace ConjuntosExercicios {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            //Conjunto não aceita repetições
            B.Add(4);

            //verificar se um elemento está no conjunto
            /*
            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if(B.Contains(n)) {
                Console.WriteLine(n + " pertence ao conjunto B");
            } else {
                Console.WriteLine(n + " não pertence ao conjunto B");
            }
            */

            //remover um elemento do conjunto
            //B.Remove(4);

            //DIFERENÇA ENTRE CONJUNTOS
            //A.ExceptWith(B);

            //UNIÃO ENTRE CONJUNTOS
            //A.UnionWith(B);

            //INTERSEÇÃO ENTRE CONJUNTOS
            A.IntersectWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }
        }
    }
}
