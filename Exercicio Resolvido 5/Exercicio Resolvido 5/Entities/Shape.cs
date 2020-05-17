﻿using Exercicio_Resolvido_5.Entities.Enums;
namespace Exercicio_Resolvido_5.Entities {
    abstract class Shape {
        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
