using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.CalculatorCore
{
    public static class MathFunctions
    {
        public static float Sin(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("sin requires exactly one argument.");
            return (float)Math.Sin(args[0]);
        }

        public static float Cos(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("cos requires exactly one argument.");
            return (float)Math.Cos(args[0]);
        }

        public static float Tan(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("tan requires exactly one argument.");
            return (float)Math.Tan(args[0]);
        }

        public static float Cot(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("cot requires exactly one argument.");
            return 1f / (float)Math.Tan(args[0]);
        }

        public static float Log(List<float> args)
        {
            if (args.Count == 1)
            {
                return (float)Math.Log10(args[0]);
            }
            else if (args.Count == 2)
            {
                return (float)Math.Log(args[1], args[0]);
            }
            else
            {
                throw new ArgumentException("log requires one or two arguments.");
            }
        }

        public static float Sqrt(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("sqrt requires exactly one argument.");
            return (float)Math.Sqrt(args[0]);
        }

        public static float FactorialFunc(List<float> args)
        {
            if (args.Count != 1)
                throw new ArgumentException("x! requires exactly one argument.");
            return Factorial(args[0]);
        }

        public static float Pow(List<float> args)
        {
            if (args.Count != 2)
                throw new ArgumentException("pow requires exactly two arguments.");
            return (float)Math.Pow(args[1], args[0]);
        }

        public static float Max(List<float> args)
        {
            if (args.Count < 2)
                throw new ArgumentException("max requires at least two arguments.");
            return args.Max();
        }

        public static float Min(List<float> args)
        {
            if (args.Count < 2)
                throw new ArgumentException("min requires at least two arguments.");
            return args.Min();
        }

        public static float Sum(List<float> args)
        {
            if (args.Count < 1)
                throw new ArgumentException("sum requires at least one argument.");
            return args.Sum();
        }

        public static float Avg(List<float> args)
        {
            if (args.Count < 1)
                throw new ArgumentException("avg requires at least one argument.");
            return args.Average();
        }
        public static float Factorial(float n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            if (n == 0 || n == 1)
                return 1;
            float result = 1;
            for (int i = 2; i <= (int)n; i++)
                result *= i;
            return result;
        }
    }
}
