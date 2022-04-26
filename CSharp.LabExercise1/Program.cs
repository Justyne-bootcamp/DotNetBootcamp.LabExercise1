using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise1
{
    class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();
            do
            {
                Console.Write("Please enter length: ");
                float length = Convert.ToSingle(Console.ReadLine());
                Console.Write("Please enter width: ");
                float width = Convert.ToSingle(Console.ReadLine());

                float area = length * width;
                float perimeter = 2 * length + 2 * width;

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();

                if(choice != "y" && choice != "Y")
                {
                    break;
                }

            } while (true);
        }

        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            Console.WriteLine();

            do
            {
                Console.Write("Please enter numerical grade: ");
                int numericalGrade = Convert.ToInt32(Console.ReadLine());
                string grade;

                if(numericalGrade >= 88)
                {
                    grade = "A";
                }
                else if(numericalGrade >= 80)
                {
                    grade = "B";
                }
                else if(numericalGrade >= 67)
                {
                    grade = "C";
                }
                else if (numericalGrade >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }
                Console.Write("Letter Grade: {0}", grade);

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();

                if (choice != "y" && choice != "Y")
                {
                    break;
                }

            } while (true);

        }
        static void Number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("This program calculates how long it will" +
                "take to download a file with a size of 56k analog modem.");

            do {
                Console.Write("Please Enter a file size (MB): ");
                int sizeInMb = Convert.ToInt32(Console.ReadLine());

                int seconds = Convert.ToInt32((sizeInMb*1024) / 5.2);
                int minutes = seconds / 60;
                seconds = seconds - (minutes * 60);
                int hours = minutes / 60;
                minutes = minutes - (hours * 60);

                Console.WriteLine("A \" 56k \" modem will take {0} hours {1} minutes {2} seconds", hours, minutes, seconds);

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();

                if (choice != "y" && choice != "Y")
                {
                    break;
                }

            } while (true);
        }
        static void Number4()
        {
            Console.WriteLine("Welcome to the Square Displayer");
            Console.WriteLine();
            
            Console.Write("Please enter square size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int height = 0; height < size; height++)
            {
                for(int width = 0; width < size; width++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 
        }
        static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
        }
    }
}
