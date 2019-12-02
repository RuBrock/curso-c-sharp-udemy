using System.Globalization;

namespace ClassesExercises1 {
    class Produto {

        public string Nome;
        public double Preco;
        public int Qtd;

        public double ValorTotalEmEstoque() {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int quantidade) {
            Qtd = Qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Qtd = Qtd - quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtd
                + " unidade(s), Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
