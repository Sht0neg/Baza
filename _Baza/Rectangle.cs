using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Baza
{
    struct Rectangle {
        private float width;
        private float height;

        public Rectangle(float width, float height)
        {
            if (width < 0)
            {
                this.width = 0;
            }
            else
            {
                this.width = width;
            }
            if (height < 0)
            {
                this.height = 0;
            }
            else
            {
                this.height = height;
            }
        }
        public float Area { get => this.height * this.width; }
        
    }
}
