using System;
using System.Collections.Generic;

namespace ListExercicio2 {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            /*O Add por padrão adiciona ao final da lista*/
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            /*O Insert pode adicionar um item num lugar determinado da lista*/
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            /******************************************/

            //Tamanho da Lista
            Console.WriteLine("\nList count: " + list.Count);

            /******************************************/

            //Encontrar a primeira ocorrência de algum item da Lista através de um predicado
            //string s1 = list.Find(Test);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nFirst 'A': " + s1);

            //Encontrar a última ocorrência de algum item da Lista através de um predicado
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s2);

            /******************************************/

            //Encontrar a primeira Posição de algum item da Lista através de um predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nFirst position 'A': " + (pos1 + 1) + " , that it's " + list[pos1]);

            //Encontrar a última Posição de algum item da Lista através de um predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + (pos2 + 1) + " , that it's " + list[pos2]);

            /******************************************/

            //Filtrar a Lista com apenas os elementos que satisfaçam o predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\n-------------------------------\n");

            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            /******************************************/

            //Remover elementos através de uma string como parametro
            Console.WriteLine("\n-------------------------------\n");

            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remover elementos que satisfaçam o predicado
            Console.WriteLine("\n-------------------------------\n");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remover elementos de uma determinada posição
            Console.WriteLine("\n-------------------------------\n");

            list.RemoveAt(3);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remover elementos de um range de posições
            Console.WriteLine("\n-------------------------------\n");

            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }

        /*
        static bool Test(string s) {
            return s[0] == 'A';
        }
        */
    }
}
