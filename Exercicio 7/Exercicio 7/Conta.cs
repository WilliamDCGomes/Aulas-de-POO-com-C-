using System.Globalization;
namespace Exercicio_7 {
    class Conta {
        //Atributos
        private string _titularConta;
        //Propriedades
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        //Construtores
        public Conta(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            _titularConta = titularConta;
        }
        public Conta(int numeroConta, string titularConta, double saldo) : this (numeroConta, titularConta) {
            Depositar(saldo);
        }
        //Propriedades Customizadas
        public string Nome {
            get { return _titularConta; }
            set {
                if(value != null && value.Length > 1) {
                    _titularConta = Nome;
                }
            }
        }
        //Métodos
        public void Depositar(double valor) {
            if(valor > 0) {
                Saldo += valor;
            }
        }
        public void Sacar(double valor) {
            if (valor > 0) {
                Saldo -= (valor + Taxa());
            }
        }
        private double Taxa() {
            return 5.00;
        }
        public override string ToString() {
            return "Conta "+ NumeroConta + ", Titular: " + _titularConta + ", Saldo: $ "+ Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
