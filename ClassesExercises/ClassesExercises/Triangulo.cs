//necessário para usar função de raiz quadradada
using System;

namespace ClassesExercises {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        //CRIANDO MÉTODOS PARA SOLUÇÃO
        public double Area() {
            double p = (A + B + C) / 2.00;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //usando variavel
            /*double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;*/
        }
    }

}
