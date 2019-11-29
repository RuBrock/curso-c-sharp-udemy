using System;
using System.Globalization;

namespace ClassesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO TRIANGULO - SOLUÇÃO COM CLASSES - MAIS OU MENOS POO - COM MÉTODOS
            double areaX, areaY;
                
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior Área: X");
            }
            else {
                Console.WriteLine("Maior Área: Y");
            }



            //EXERCICIO TRIANGULO - SOLUÇÃO COM CLASSES - POO - SEM MÉTODOS
            /*double areaX, areaY, p;

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (x.A + x.B + x.C) / 2.0;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior Área: X");
            }
            else {
                Console.WriteLine("Maior Área: Y");
            }*/



            //EXERCICIO TRIANGULO - SOLUÇÃO SEM CLASSES - SEM POO
            /*
            double xA, xB, xC, yA, yB, yC, p; 

            Console.WriteLine("Entre com as medidas do triângulo X:");
                xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
                yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            } else
            {
                Console.WriteLine("Maior Área: Y");
            }
            */

        }
    }
}
