using Exercicio_Resolvido_5.Entities;
using Exercicio_Resolvido_5.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio_Resolvido_5 {
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfShapes; i++) {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char typeOfShape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color colorOfShape = Enum.Parse<Color>(Console.ReadLine());
                if(typeOfShape == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, colorOfShape));
                }
                else if(typeOfShape == 'c') {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, colorOfShape));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape s in list) {
                Console.WriteLine(s.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
