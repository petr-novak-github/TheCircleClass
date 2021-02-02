using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCircleClass
{
   
    public class TestCircle
    {
      public static void Main(string[] args)
        {
            Circle c1 = new Circle();
          
            Console.WriteLine( "The circle has radius of " + c1.getRadius() + " and area of " + c1.getArea() + " and color is " + c1.getColor());
            
            Circle c2 = new Circle(2.0);

            Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea() + " and color is " + c2.getColor());

            Circle c3 = new Circle(3.0, "pink");

            Console.WriteLine("The circle has radius of " + c3.getRadius() + " and area of " + c3.getArea() + " and color is " + c3.getColor());

            //Console.WriteLine(c1.radius); nejde radius je datova slozka tridy Circle ktera je privatni, pristup k ni je mozno jen pres getter a setter

            //c1.radius = 5.0; nejde radius je datova slozka tridy Circle ktera je privatni, pristup k ni je mozno jen pres getter a setter


            Circle c4 = new Circle();
            c4.setRadius(5.5);
            Console.WriteLine("radius is: " + c4.getRadius());
            c4.setColor("yellow");
            Console.WriteLine("color is: " + c4.getColor());


            Circle c5 = new Circle(1.0);
            Console.WriteLine(c5.toString());
            Console.WriteLine(c5);

            Console.ReadLine();

        }
    }
}
