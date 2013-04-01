using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests
{

    class Cylinder
    { 
    
        private double radius, heigth;
        


   


        public double Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double GetVolume()
        {

            return radius *  radius * heigth * Math.PI;
        }

        public double GetDiametr()
        {
            return 2 * radius ;
        }

        public double GetArea()
        {
            return (2 * Math.PI * radius * radius) + (2 * Math.PI * radius * heigth);
        }
      
        public double GetException()
        {
            if (heigth <= 0 || radius <= 0)
                return -1;
            else
                return GetVolume();
        
        }


        public Cylinder( double heigth, double radius)
        {
           Heigth = heigth;
            Radius = radius;
            
        }
      
      
    }

    class Program
    {
        static void Main(string[] args)
        {
           Cylinder cylinder = new Cylinder(2,2);
           Console.WriteLine("Объем цилиндра равен " + cylinder.GetVolume());
           Console.WriteLine("Площадь цилиндра равна " + cylinder.GetArea());
           Console.WriteLine("Диаметр цилиндра равен " + cylinder.GetDiametr());
           Console.ReadLine();
        }
    }
}
