using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //public  class Persons
    // {
    //     public virtual void Hello()
    //     {
    //         Console.WriteLine("Hello");
    //     }
    // }

    // class Employee :Persons { 
    // public override void Hello()
    //     {
    //         Console.WriteLine("Hello");
    //     }


    // }




    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }

  
    }




