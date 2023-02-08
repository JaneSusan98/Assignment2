using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaneSusan_Rajesh_8811392_Assignment2
{
    public class Circle
    {
        private int radius;
        public int userRadius;

        //default constructor
        public Circle()
        {
            radius = 1;
        }

        //parameterized constructor
        public Circle(int userRadius)
        {
            radius = userRadius;
        }
        public int GetRadius(int userRadius)
        {
            return radius;

        }

        public void SetRadius(int userRadius)
        {
            Console.WriteLine("\nPlease enter the new radius of the circle: ");
            while (!int.TryParse(Console.ReadLine(), out userRadius) || userRadius <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a value greater than 0.");
            }
            Console.WriteLine("\nThe radius of the circle has been changed to " + userRadius + ".");
            radius = userRadius;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public double GetArea()
        {
            double area= Math.PI * radius * radius;
            return area;
        }
    }
}
