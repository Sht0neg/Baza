using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDz1
{
    internal class Button
    {
        private int width;
        private int height;
        private string color;
        private string name;

        public Button(string name)
        {
            this.Name = name;
            this.Color = "red";
            this.Width = 400;
            this.Height = 100;
        }

        public Button(string color, string name)
        {
            this.Color = color;
            this.Name = name;
            this.Width = 400;
            this.Height = 100;
        }

        public Button(int width, int height, string color, string name)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.Name = name;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }

        public void Print() {
            Console.WriteLine($"Название кнопки: {this.Name}, цвет: {this.Color}, ширина: {this.Width}, высота: {this.Height}");
        }
    }
}
