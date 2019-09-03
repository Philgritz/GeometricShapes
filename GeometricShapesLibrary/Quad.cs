using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Quadrilateral {

        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public int Perimeter() {
            return Side1 + Side2 + Side3 + Side4;
        }

        public Quadrilateral(int side1, int side2, int side3, int side4) {   //constructor

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;


        }
    }
}
