using System;

namespace DN_RecursiveCalculator
{
    
    public class Program
    {
        public enum CalcType { add, subtract, multiply, divide, useRoot, useExponent };

        static void Main(string[] args)
        {
            Calculator(4, CalcType.add, 2);
            Calculator(4, CalcType.subtract, 2);
            Calculator(4, CalcType.multiply, 2);
            Calculator(2, CalcType.divide, 2);
            Calculator(4, CalcType.useRoot, 2);
            Calculator(4, CalcType.useExponent, 2);
            Console.ReadLine();
        }

        /// <summary>
        /// Takes 2 integers and a calculation type and returns a console of the answer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="calcType"></param>
        /// <param name="b"></param>
        static void Calculator(decimal a, CalcType calcType, decimal b )
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
        public static decimal Add(decimal a, decimal b)
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
        public static decimal Subtract(decimal a, decimal b)
        {
            if (b == 0)
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
        public static decimal Multiply(decimal a, decimal b)
        {
            if (b == 0)
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
        public static decimal Divide(decimal a, decimal b)
        {
            decimal counter = 0;

            decimal HelperDivide(decimal aHelper, decimal bHelper, decimal counterHelper)
            {
                if (bHelper == 0)
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
        public static decimal NthRoot(decimal a, decimal b)
        {
            decimal counter = 0;
            decimal HelperRoot( decimal aHelper, decimal bHelper, decimal counterHelper)
            {
                if(aHelper == 0)
                {
                    return counterHelper;
                }
                else
                {

                    return HelperRoot(aHelper - bHelper, bHelper, counterHelper + 1);
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
        public static decimal Exponent(decimal a, decimal b )
        {
            b = b - 1;
            decimal HelperExponent(decimal aHelper, decimal bHelper)
            {
                if (bHelper == 0)
                {
                    return aHelper;
                }
                else
                {
                    return HelperExponent(aHelper * aHelper, bHelper - 1);
                }
            }
              a = HelperExponent(a, b);
            return a;
        }
    }
}
