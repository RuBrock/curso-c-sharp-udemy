using System;
using System.Globalization;

namespace DateTimeExercicios {
    class Program {
        static void Main(string[] args) {

            /*BUILDERS BASICOS*/
            //DateTime d1 = DateTime.Now; //Horario atual do Sistema
            //DateTime d5 = DateTime.Today; //data de hoje, com hora zerada
            //DateTime d6 = DateTime.UtcNow; //horario de agr, horario universal GMT
            //Console.WriteLine(d1);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            /*CONSTRUTORES MAIS UTILIZADOS*/
            //Instancia do DateTime em determinada data, data/hora, data/hora/milisegundos
            //DateTime d2 = new DateTime(2018, 11, 25);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);
            //DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); //para apresentar esse horario, existem diferentes formatações
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //Ticks - Maneira que datas são armazenadas no sistema
            //Console.WriteLine(d1.Ticks); 


            /*CONVERSAO DE DATAS*/
            DateTime d10 = DateTime.Parse("2000-08-15");
            DateTime d20 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d30 = DateTime.Parse("15/08/2000");
            DateTime d40 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d50 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d60 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d10);
            //Console.WriteLine(d20);
            //Console.WriteLine(d30);
            //Console.WriteLine(d40);
            Console.WriteLine(d50);
            Console.WriteLine(d60);


        }
    }
}
