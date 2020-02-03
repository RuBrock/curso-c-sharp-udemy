using System;

namespace TimeSpanExercises {
    class Program {
        static void Main(string[] args) {

            TimeSpan t0 = new TimeSpan(0, 1, 30);//horas, minutos, segundos
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(1, 2, 11, 21);//dias, horas, minutos, segundos
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);//dias, horas, minutos, segundos, milisegundos

            /*Usos do TimeSpan (H, M, S)*/
            Console.WriteLine(t0);
            Console.WriteLine(t0.Ticks);
            Console.WriteLine();

            /*TimeSpan Construtor padrão*/
            Console.WriteLine(t1);
            Console.WriteLine();

            /*TimeSpan Construtor qtd Ticks*/
            Console.WriteLine(t2);

            /*TimeSpan Construtor (D, H, M, S)*/
            Console.WriteLine(t3);

            /*TimeSpan Construtor (D, H, M, S, MS)*/
            Console.WriteLine(t4);
            Console.WriteLine();



            /*INSTANCIAR TIMESPAN COM METODOS FROM*/
            TimeSpan tf0 = TimeSpan.FromDays(1.5);
            Console.WriteLine(tf0);

            TimeSpan tf1 = TimeSpan.FromHours(1.5);
            Console.WriteLine(tf1);

            TimeSpan tf2 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(tf2);

            TimeSpan tf3 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(tf3);

            TimeSpan tf4 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(tf4);

            TimeSpan tf5 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(tf5);

        }
    }
}
