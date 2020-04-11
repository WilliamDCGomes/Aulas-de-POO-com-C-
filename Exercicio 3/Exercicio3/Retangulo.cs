using static System.Math;
namespace Exercicio3 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }
        public double Perimetro() {
            return (Largura*2)+(Altura*2);
        }
        public double Diagonal() {
            return Sqrt(Pow(Largura,2)+Pow(Altura,2));
        }

    }
}
