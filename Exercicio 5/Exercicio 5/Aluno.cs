using System.Globalization;
namespace Exercicio_5 {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        private double NotaFinal() {
            return (Nota1 + Nota2 + Nota3);
        }
        public string Apro() {
            if (NotaFinal() >= 60.0) {
                return "APROVADO";
            }
            else{
                return "REPROVADO\nFALTARAM " + (60.0 - NotaFinal()).ToString("F2",CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
        public override string ToString() {
            return "NOTA FINAL = "+NotaFinal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }    
}