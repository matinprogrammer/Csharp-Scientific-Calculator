using System;
using System.Collections.Generic;
using System.Linq;

namespace ScientificCalculator.CalculatorCore
{
    public class PostFixCalculator : ICalculator
    {
        Dictionary<string, Func<List<float>, float>> operatorsFunc = new Dictionary<string, Func<List<float>, float>>
        {
            { "sin", MathFunctions.Sin },
            { "cos", MathFunctions.Cos },
            { "tan", MathFunctions.Tan },
            { "cot", MathFunctions.Cot },
            { "log", MathFunctions.Log },
            { "sqrt", MathFunctions.Sqrt },
            { "x!", MathFunctions.FactorialFunc },
            { "pow", MathFunctions.Pow },
            { "max", MathFunctions.Max },
            { "min", MathFunctions.Min },
            { "sum", MathFunctions.Sum },
            { "avg", MathFunctions.Avg },
        };

        Dictionary<string, int> operatorsPriority = new Dictionary<string, int>
        {
            { "(", 12 },
            { ")", 12 },

            { "sin", 11 },
            { "cos", 11 },
            { "tan", 11 },
            { "cot", 11 },
            { "asin", 11 },
            { "atan", 11 },
            { "sqrt", 11 },
            { "log", 11 },
            { "sum", 11 },
            { "avg", 11 },
            { "max", 11 },
            { "min", 11 },

            { "^", 10 },
            { "pow", 10 },

            { "*", 9 },
            { "/", 9 },
            { "%", 9 },

            { "+", 8 },
            { "-", 8 },
        };

        public float evaluate(string mathExpression)
        {
            List<string> infixMathExpression = sliceInfixStringToList(mathExpression);
            List<string> postfixMathExpression = convertInfixToPostfix(infixMathExpression);
            return evaluatePostfix(postfixMathExpression);
        }

        char detectCharType(char ch)
        {
            if (ch == ',')
                return ',';
            if (char.IsDigit(ch))
                return 'D';
            if (ch == '(' | ch == ')')
                return 'P';
            if (char.IsLetter(ch))
                return 'L';
            if (char.IsPunctuation(ch) || char.IsSymbol(ch))
                return 'S';
            throw new FormatException("Unsuported type");
        }

        char detectStringType(string st)
        {
            char outputChar = detectCharType(st[0]);
            foreach (char ch in st)
            {
                if (outputChar != detectCharType(ch))
                {
                    throw new FormatException("All char of string has not same type");
                }
            }
            return outputChar;
        }

        List<string> sliceInfixStringToList(string mathExpression)
        {
            string currentString = "";
            char currentChType = detectCharType(mathExpression[0]);
            List<string> output = new List<string>();

            foreach (char ch in mathExpression)
            {
                char chType = detectCharType(ch);
                if (chType != currentChType)
                {
                    output.Add(currentString);
                    currentString = ch.ToString();
                    currentChType = chType;
                }
                else
                {
                    if (chType == 'P' && currentString.Length > 0)
                    {
                        output.Add(currentString);
                        currentString = "";
                    }
                    currentString += ch;
                }
            }
            output.Add(currentString);
            return output;
        }

        List<string> convertInfixToPostfix(List<string> infixMathExpression)
        {
            Stack<string> stack = new Stack<string>();
            List<string> output = new List<string>();

            foreach (string st in infixMathExpression)
            {
                char stType = detectStringType(st);
                if (stType == 'D')
                {
                    output.Add(st);
                    continue;
                }
                if (stType == 'S' || stType == 'L')
                {
                    int stPriority = operatorsPriority[st.ToLower()];
                    while (true)
                    {
                        if (stack.Count == 0)
                        {
                            stack.Push(st);
                            break;
                        }

                        string lastItem = stack.Pop();
                        if (stPriority > operatorsPriority[lastItem.ToLower()])
                        {
                            stack.Push(lastItem);
                            stack.Push(st);
                            break;
                        }
                        else
                        {
                            output.Add(lastItem);
                            continue;
                        }
                    }
                }
                if (st == "(")
                {
                    output.Add(",");
                }
            }
            foreach (string item in stack)
            {
                output.Add(item);
            }
            return output;
        }

        float evaluatePostfix(List<string> postfixMathExpression)
        {
            Stack<string> stack = new Stack<string>();
            foreach (var st in postfixMathExpression)
            {
                char stType = detectStringType(st);
                if (stType == 'D' || stType == ',')
                {
                    stack.Push(st);
                    continue;
                }
                if (stType == 'S')
                {
                    float numberTwo = float.Parse(stack.Pop());
                    float numberOne = float.Parse(stack.Pop());
                    stack.Push(evaluateOperator(st, numberOne, numberTwo).ToString());
                }
                if (stType == 'L')
                {
                    List<float> numbers = new List<float>();
                    while (true)
                    {
                        if (stack.Count == 0)
                            break;

                        string number = stack.Pop();
                        char numberType = detectStringType(number);
                        if (numberType == 'D')
                        {
                            numbers.Add(float.Parse(number));
                        }
                        else
                        {
                            break;
                        }
                    }
                    stack.Push(operatorsFunc[st.ToLower()](numbers).ToString());
                }

            }
            return float.Parse(stack.Pop());
        }

        float evaluateOperator(string operator_, float numberOne, float numberTwo = 0)
        {
            float output = 0;
            switch (operator_)
            {
                case "+":
                    output = numberOne + numberTwo;
                    break;
                case "-":
                    output = numberTwo - numberOne;
                    break;
                case "*":
                    output = numberOne * numberTwo;
                    break;
                case "/":
                    output = numberOne / numberTwo;
                    break;
            }
            return output;
        }
    }
}
