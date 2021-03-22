using HerdarVSCumprirContrato.Model.Enums;

namespace HerdarVSCumprirContrato.Model.Entities {
    abstract class Shape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
