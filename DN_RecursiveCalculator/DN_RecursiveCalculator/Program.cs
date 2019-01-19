﻿using System;

namespace DN_RecursiveCalculator
{
    
    public class Program
    {
        public enum CalcType { add, subtract, multiply, divide, useRoot, useExponent };

        static void Main(string[] args)
        {
            Calculator(400, CalcType.add, 2);
            Calculator(4, CalcType.subtract, 2);
            Calculator(4, CalcType.multiply, 2);
            Calculator(5, CalcType.divide, 2);
            Calculator(3, CalcType.useRoot, 3);
            Calculator(3, CalcType.useExponent, 3);
            Console.ReadLine();
        }


        /// <summary>
        /// Takes 2 integers and a calculation type and returns a console of the answer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="calcType"></param>
        /// <param name="b"></param>
        static void Calculator(int a, CalcType calcType, int b )
        {
            
            switch (calcType)
            {
                case CalcType.add:
                    Console.WriteLine($"{a} + {b} = {Add(a, b)}");
                    break;
                case CalcType.subtract:
                    Console.WriteLine($"{a} - {b} = {Subtract(a, b)}");
                    break;
                case CalcType.multiply:
                    Console.WriteLine($"{a} * {b} = {Multiply(a, b)}");
                    break;
                case CalcType.divide:
                    Console.WriteLine($"{a} / {b} = {Divide(a, b)}");
                    break;
                case CalcType.useRoot:
                    Console.WriteLine($"{b} root of {a} = {NthRoot(a, b)}");
                    break;
                case CalcType.useExponent:
                    Console.WriteLine($"{a} ^ {b} = {Exponent(a, b)}");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// a + b. b must be positive.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int Add(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return Add(a + 1, b - 1);
        }

        /// <summary>
        /// a - b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int Subtract(int a, int b)
        {
            if (b < 1)
            {
                return a;
            }

            return Subtract(a - 1, b - 1);
        }

        /// <summary>
        /// a * b. b must be positive.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int Multiply(int a, int b)
        {
            if (b == 1)
            {
                return 0;
            }

            return a + Multiply(a , b - 1);
        }

        /// <summary>
        /// a / b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int Divide(int a, int b)
        {
            int counter = 0;

            int HelperDivide(int aHelper, int bHelper, int counterHelper)
            {
                if (bHelper < 1)
                {
                    return 0;
                }
                if (aHelper < bHelper)
                {
                    return 0;
                }
                else
                {
                    counter = counter + 1;
                    return ((aHelper - bHelper) - HelperDivide(aHelper - bHelper, bHelper, counter));
                }
            }
            HelperDivide(a, b, counter);
            return counter;
            
        }

        /// <summary>
        /// b root of a. Only returns whole integer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int NthRoot(int a, int b)
        {
            int counter = 0;
            int HelperRoot(int aHelper, int bHelper, int counterHelper)
            {
                if(aHelper < 2)
                {
                    return counterHelper;
                }
                else
                {
                    counterHelper = counterHelper + 1;
                    return HelperRoot(aHelper / bHelper, bHelper, counterHelper);
                }
            }
            counter = HelperRoot(a, b, counter);
            
            return counter;
        }

        /// <summary>
        /// a ^ b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int Exponent(int a, int b )
        {
            b = b - 1;
            int HelperExponent(int aHelper, int bHelper)
            {
                if (bHelper < 1)
                {
                    return aHelper;
                }
                else
                {
                    return HelperExponent(aHelper * a, bHelper - 1);
                }
            }
              a = HelperExponent(a, b);
            return a;
        }
    }
}
