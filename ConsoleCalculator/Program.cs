using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // varaibles
            Operations ops = new Operations();
            double firstNum;
            double secondNum;
            double answer;
            string operation;
            Console.WriteLine("\t\tC# Console Calculator");
            Console.WriteLine("\t\t===========================");

            // reads key input for first number
            
                Console.WriteLine("\n\nEnter first number...(Press enter to confirm)");
                firstNum = Double.Parse(Console.ReadLine());

                // reads key input for the selected operation
                Console.WriteLine("\n\nSelect an operator (+,-,x,/,%,^, AVG)...(Press enter to confirm)");
                operation = Console.ReadLine();

            // reads key input for second number
            if (operation != "SR")
            {
                Console.WriteLine("\n\nEnter second number...(Press enter to confirm)");
                secondNum = Double.Parse(Console.ReadLine());


                //////////// if statements that handle what operation to use depending on what operation the user picks
                if (operation == "+")
                {
                    answer = ops.Addition(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "-")
                {
                    answer = ops.Subtraction(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "x")
                {
                    answer = ops.Multiplication(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "/")
                {
                    answer = ops.Division(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "%")
                {
                    answer = ops.Modulus(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "^")
                {
                    answer = ops.Sqr(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                if (operation == "AVG" || operation == "avg" || operation == "Avg")
                {
                    answer = ops.Avg(firstNum, secondNum);

                    Console.Write("\n\nThe answer is " + answer);
                }

                

            }

            else 
            if(operation == "SR" || operation == "sr" || operation == "Sr") 
            { 
                
                answer = ops.SR(firstNum);

                Console.Write("\n\nThe answer is " + answer);
            }
            ///////////////////////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }

        
    }

    // class stores mathematical operations
    public class Operations
    {
        public double Addition(double a, double b)
        {
            return a + b;

        }

        public double Subtraction(double a, double b)
        {
            return a - b;

        }

        public double Multiplication(double a, double b)
        {
            return a * b;

        }

        public double Division(double a, double b)
        {
            return a / b;

        }

        public double Modulus(double a, double b)
        {
            return a % b;

        }

        public double Sqr(double a, double b)
        {
            return Math.Pow(a, b);

        }

        public double Avg(double a, double b)
        {
            return (a + b) / 2;
           

        }

        public double SR(double a)
        {
            return Math.Sqrt(a);

        }


    }


}
