using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDz3
{
    internal class Rectangle
    {
        private float width;
        private float height;

        public float Width { get => width; set => width = (value >= 0) ? value : width; }
        public float Height { get => height; set => height = (value >= 0) ? value : height; }

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(float width)
        {
            Width = width;
            Height = height;
        }
    }
}
