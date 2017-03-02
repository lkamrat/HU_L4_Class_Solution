using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_L4_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
            {
                Console.WriteLine("The high number is: {0}", numOne);
            }
            else
            {
                Console.WriteLine("The high number is: {0}", numTwo);
            }

            Console.WriteLine("Please enter three numbers");
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            if ((numA > numB) && (numA > numC))
            {
                Console.WriteLine("The highest number is {0}", numA);
            }

            if ((numB > numA) && (numB > numC))
            {
                Console.WriteLine("The highest number is {0}", numB);
            }
            if ((numC > numA) && (numC > numB))
            {
                Console.WriteLine("The highest number is {0}", numC);
            }

            // Practice Nested if

            Console.WriteLine("Please enter three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 >= num2) && (num1 >= num2))
            {
                Console.WriteLine("The highest number is: {0}", num1);
            }
            else
            {
                if ((num2 >= num1) && (num2 >= num3))
                {
                    Console.WriteLine("The highest number is: {0}", num2);
                }

                else
                {
                    Console.WriteLine("The highest number is: {0}", num3);
                }

            }

            Console.WriteLine("Enter 2-digit number");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = (number / 10);
            int secondDigit = (number % 10);
            if ((number >= 100) || (number < 10))
            {
                Console.WriteLine("You are tambal");
            }
            else
            {
                Console.WriteLine("The digit sum is {0}", firstDigit + secondDigit);
            }

            // for loop excer

            Console.WriteLine("Please enter a number");
            int myNum = int.Parse(Console.ReadLine());
            int mySum = 0;
            for (int i = 0; i < myNum; i++)
            {
                Console.WriteLine("My sum is :{0}", mySum);
                mySum = mySum + i;
            }

        }
    }
}
