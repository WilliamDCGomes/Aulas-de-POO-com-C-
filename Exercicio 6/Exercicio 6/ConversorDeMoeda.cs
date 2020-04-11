namespace Exercicio_6 {
    class ConversorDeMoeda {
        public static double CotacaoDolar;
        public static double QuantDolarComprar;
        
        private static double IOF() {
            return CotacaoDolar * QuantDolarComprar * 0.06;
        }

        public static double ValorASerPago() {
            return IOF() + (CotacaoDolar * QuantDolarComprar);
        }
    }
}
