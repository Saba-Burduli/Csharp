using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anoterhomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.calculate(2, 3, '+')); 
            Console.WriteLine(calc.calculate(2.5, 3, '+')); 
            Console.WriteLine(calc.calculate(5, 2, '-')); 
            Console.WriteLine(calc.calculate(4, 5, '*')); 
            Console.WriteLine(calc.calculate(10, 2, '/')); 

            Console.ReadLine();



        }



    };






    public class Calculator {



        public int calculate(int num1, int num2, char operation)
        {
            if (operation == '+')
                return num1 + num2;
            else if (operation == '-')
                return num1 - num2;
            else if (operation == '*')
                return num1 * num2;
            else if (operation == '/')
                return num1 / num2;
            else
                throw new ArgumentException("Invalid operation");
        }

        public double calculate(double num1, int num2, char operation)
        {
            if (operation == '+')
                return num1 + num2;
            else if (operation == '-')
                return num1 - num2;
            else if (operation == '*')
                return num1 * num2;
            else if (operation == '/')
                return num1 / num2;
            else
                throw new ArgumentException("Invalid operation");
        }

        public double calculate(int num1, double num2, char operation)
        {
            if (operation == '+')
                return num1 + num2;
            else if (operation == '-')
                return num1 - num2;
            else if (operation == '*')
                return num1 * num2;
            else if (operation == '/')
                return num1 / num2;
            else
                throw new ArgumentException("Invalid operation");
        }

        public double calculate(double num1, double num2, char operation)
        {
            if (operation == '+')
                return num1 + num2;
            else if (operation == '-')
                return num1 - num2;
            else if (operation == '*')
                return num1 * num2;
            else if (operation == '/')
                return num1 / num2;
            else
                throw new ArgumentException("Invalid operation");
        }




    }











}






