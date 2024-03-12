using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDz3
{
    internal class Polygon
    {
        private float[] sides;

        public Polygon(params float[] sides)
        {
            this.sides = sides;
        }

        public float Perimetr {
            get {
                float sum = 0;
                foreach (float i in sides) {
                    sum += i;
                }
                return sum;
            }  
        }

    }
}
