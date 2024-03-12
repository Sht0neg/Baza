using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polnay_Baza
{
    abstract class Figure
    {
        private string _color;

        public string Color { get => _color; set => _color = value; }

        public Figure(string color)
        {
            Color = color;
        }

        abstract public float Area();
        abstract public float Perimetr();
    }

    class Circle : Figure
    {
        private float _radius;

        public float Radius { get => _radius; set => _radius = value; }

        public Circle(string color, float radius) : base(color)
        {
            Radius = radius;
        }
        public override float Area()
        {
            return 3.14f * Radius * Radius;
        }
        public override float Perimetr()
        {
            return 2 * 3.14f * Radius;
        }
    }

    class Rectangle : Figure {

        private float _a;
        private float _b;

        public float A { get => _a; set => _a = value; }
        public float B { get => _b; set => _b = value; }

        public Rectangle(string color, float a, float b) : base(color)
        {
            A = a;
            B = b;
        }

        public override float Area()
        {
            return A * B;
        }

        public override float Perimetr()
        {
            return (A + B) * 2;
        }
    }

    class Triangle : Figure {
        private float _h;
        private float _a;
        private float _b;
        private float _c;

        public float H { get => _h; set => _h = value; }
        public float C { get => _c; set => _c = value; }
        public float A { get => _a; set => _a = value; }
        public float B { get => _b; set => _b = value; }

        public Triangle(string color, float h, float c, float a = 0, float b = 0) : base(color)
        {
            H = h;
            C = c;
            A = a;
            B = b;
        }

        public override float Area()
        {
            return H * C / 2;
        }

        public override float Perimetr()
        {
            return A + B + C;
        }

    }

}
