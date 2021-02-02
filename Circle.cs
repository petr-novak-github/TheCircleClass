using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCircleClass
{
    public class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;

        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return Math.PI * Math.Sqrt(radius);
        }

        public string getColor() {

            return color;
        }

        public void setRadius(double radius) {
            this.radius = radius;
        }

        public void setColor(string color) {

            this.color = color;
        }

        public String toString() {
            return "Circle[radius=" + radius + " color=" + color + "]";
        }




    }
}
