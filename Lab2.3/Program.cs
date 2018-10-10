using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswerContinue;
            double answerPerimeter, answerArea, answervolume, length, width, height;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! \n");

            do
            {
                //user inputs
                Console.WriteLine("Enter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height: ");
                height = double.Parse(Console.ReadLine());

                //logic
                answerPerimeter = (length * 2) + (width * 2);
                answerArea = length * width;
                answervolume = length * width * height;

                //answer     
                Console.WriteLine("{0} {1} {2}", "Area: " + answerArea,
                    "\nPerimeter: " + answerPerimeter, "\nVolume: " + answervolume);

                // check for yes or no only.
                do
                {
                    Console.WriteLine("Continue? (y/n): ");
                    userAnswerContinue = Console.ReadLine().ToLower();
                } while (userAnswerContinue != "y" && userAnswerContinue != "n");
            //continue Main loop
            } while (userAnswerContinue != "n");
        }
    }
}
