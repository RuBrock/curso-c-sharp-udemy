using System.Globalization;

namespace POOExercises1 {
    class ContaBancaria {
        
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double depositoIni) : this(conta, titular) {
            AdicionaDeposito(depositoIni);
        }

        public void AdicionaDeposito(double deposito) {
            Saldo += deposito;
        }

        public void RealizaSaque(double saque) {
            Saldo = (Saldo - saque) - 5.00;
        }

        public override string ToString() {
            return "Conta " +
                Conta +
                ", Titular: " +
                Titular +
                ", Saldo: $" +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
