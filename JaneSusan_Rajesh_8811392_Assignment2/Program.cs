using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaneSusan_Rajesh_8811392_Assignment2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            int radius;
            while (!int.TryParse(Console.ReadLine(), out radius)||radius <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a value greater than 0.");
            }
            
            Circle circle = new Circle(radius);
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");

                while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
                {
                    Console.WriteLine("Invalid input! Please enter a valid option.");
                }
                circle.userRadius = radius;
                if (option == 1)
                {
                    Console.WriteLine("\nThe radius of the circle is " + circle.userRadius + ".");
                }
                else if (option == 2)
                {
                    circle.SetRadius(radius);
                    
                }
                else if (option == 3)
                {
                    Console.WriteLine("\nThe circumference of the circle is " + circle.GetCircumference() + ".");
                }
                else if (option == 4)
                {
                    Console.WriteLine("\nThe area of the circle is " + circle.GetArea() + ".");
                    
                }
            }
        }
    }
}