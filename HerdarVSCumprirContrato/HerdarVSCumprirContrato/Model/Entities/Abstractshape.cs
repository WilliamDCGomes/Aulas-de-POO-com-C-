using HerdarVSCumprirContrato.Model.Enums;

namespace HerdarVSCumprirContrato.Model.Entities {
    abstract class Abstractshape : IShape{
        public Color Color { get; set; }

        public abstract double Area();
    }
}
