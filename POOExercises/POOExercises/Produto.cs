using System.Globalization;

namespace POOExercises {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Qtd = quantidade;
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        /*public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public double GetPreco() {
            return _preco;
        }

        public double Qtd {
            get { return _qtd; }
        }
        
        public int GetQtd() {
            return _qtd;
        }*/

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
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtd
                + " unidade(s), Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
