using System;
using System.Globalization;

namespace POOExercises1 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria cb;

            Console.Write("Insira o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Insira o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? ");
            char stDeposito = char.Parse(Console.ReadLine());

            if(stDeposito == 's' || stDeposito == 'S') {
                Console.Write("Insira o valor de depósito incial: ");
                double depositoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cb = new ContaBancaria(conta, titular, depositoIni);
            } else {
                cb = new ContaBancaria(conta, titular);
            }

            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine(cb);

            Console.Write("\nInsira um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.AdicionaDeposito(deposito);

            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(cb);

            Console.Write("\nInsira um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.RealizaSaque(saque);

            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(cb);


        }
    }
}
