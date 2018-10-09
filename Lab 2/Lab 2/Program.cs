using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string Continue;
            double lengthInput;
            double widthInput;
            double heightInput;

            do
            {
                Console.Clear();
                Console.Write("Please enter length of room: ");
                lengthInput = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter width of room: ");
                widthInput = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter height of room: ");
                heightInput = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area: " + lengthInput * widthInput);
                Console.WriteLine("Perimeter: " + (lengthInput * 2) + (widthInput * 2));
                Console.WriteLine("Volume: " + lengthInput * widthInput * heightInput);

                Console.WriteLine("Calculate another room? (y/n): ");
                Continue = Console.ReadLine();
            } while (Continue != "N" && Continue != "n");


            
            
        }

       

        
    }
}