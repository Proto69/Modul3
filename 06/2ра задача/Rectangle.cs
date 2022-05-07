using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        private string id;
        private double x1;
        private double x2;
        private double y1;
        private double y2;

        public Rectangle(string id, double width, double height, double x1, double y1)
        {
            Id = id;
            X1 = x1;
            Y1 = y1;
            X2 = X1 - width;
            Y2 = Y1 - height;

        }

        public string Id { get => id; set => id = value; }
        public double X1 { get => x1; set => x1 = value; }
        public double X2 { get => x2; set => x2 = value; }
        public double Y1 { get => y1; set => y1 = value; }
        public double Y2 { get => y2; set => y2 = value; }
    }
}
