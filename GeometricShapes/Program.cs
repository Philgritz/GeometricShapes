using GeometricShapesLibrary;
using System;

namespace GeometricShapes {
    class Program {

        void Run() {
            var quad1 = new Quadrilateral(2,3,4,5);    //must use values from constructor
            Console.WriteLine($"quad1: perimeter is {quad1.Perimeter()}");

            var pgram1 = new Parallelegram(6, 7); //Perimeter method can be used because it was inherited
            Console.WriteLine($"pgram1: perimeter is {pgram1.Perimeter()} and area is {pgram1.Area()}");

            var sqr1 = new Square(10);
            Console.WriteLine($"sqr1: perimeter is {sqr1.Perimeter()} and area is {sqr1.Area()}");

            var tri1 = new Triangle(2, 3, 4);    //must use values from constructor
            Console.WriteLine($"tri1: perimeter is {tri1.Perimeter()}");
        }

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
