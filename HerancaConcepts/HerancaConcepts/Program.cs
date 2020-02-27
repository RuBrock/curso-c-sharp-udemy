using System;
using HerancaConcepts.Entities;

namespace HerancaConcepts {
    class Program {
        static void Main(string[] args) {

            BusinessAccount account = new BusinessAccount(8010, "Jack Ryan", 100.00, 500.00);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.00;

        }
    }
}
