﻿using System;
using System.Linq.Expressions;

namespace HelloWorld
{
    public class Math
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine("The sum of num1 and num2 is " + (num1 + num2));
        }

        public void sub(int num1, int num2)
        {
            Console.WriteLine("The difference of num1 and num2 is " + (num1 - num2));
        }

        public void mul(int num1, int num2)
        {
            Console.WriteLine("The product of num1 and num2 is " + (num1 * num2));
        }

        public void div(int num1, int num2)
        {
            Console.WriteLine("The quotient of num1 and num2 is " + (num1 / num2));
        }
    }
    class Program
    {   

        static void Main(string[] args)
        {
            Math m = new Math();
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            /*Console.WriteLine("+ - * /");
            Console.Write("Enter choice: ");
            String choice = (Console.ReadLine());

            switch (choice)
            {
                case "+":
                    Console.WriteLine(m.add);
                    break;
                case "-":
                    Console.WriteLine(m.sub);
                    break;
                case "*":
                    Console.WriteLine(m.mul);
                    break;
                case "/":
                    Console.WriteLine(m.div);
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE!!!");
                    break;
            }*/

            m.add(num1, num2);
            m.sub(num1, num2);
            m.mul(num1, num2);
            m.div(num1, num2);
        }
    }
}