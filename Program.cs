using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Please enter in length");
            string Length = Console.ReadLine();
            double length = double.Parse(Length);
            Console.WriteLine("Please enter in width");
            string Width = Console.ReadLine();
            double width = double.Parse(Width);
            Console.WriteLine("Please enter in height");
            string Height = Console.ReadLine();
            double height = double.Parse(Height);
           
            //math
            double perimeter = (2 * length) + (2 * width);
            double area = length * width;
            double volume = area * height;
            //outputs
            Console.WriteLine("The Perimeter of the room is" + perimeter);
            Console.WriteLine("The Area of the room is " + area);
            Console.WriteLine("the Volume of the room is" + volume);

            // loops
            Console.WriteLine("Continue? (y/n)");

            char again = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine(again);

            if (again.Equals(Char.Parse("Y")))

            {

               

            }

        }

    }

}



        








            
            
            



        