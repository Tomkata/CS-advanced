using System;
using System.Collections.Generic;

class Calculator
{
    public static int EvaluateExpression(string expression)
    {
        Stack<int> stack = new Stack<int>();
        int currentNumber = 0;
        char currentOperator = '+';

        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                currentNumber = currentNumber * 10 + (c - '0');
            }
            else if (c == '+' || c == '-')
                {
                if (currentOperator == '+')
                {
                    stack.Push(currentNumber);
                }
                else if (currentOperator == '-')
                {
                    stack.Push(-currentNumber);
                }
                currentNumber = 0;
                currentOperator = c;
            }
        }

        if (currentOperator == '+')
        {
            stack.Push(currentNumber);
        }
        else if (currentOperator == '-')
        {
            stack.Push(-currentNumber);
        }



        return stack.Sum();
    }

    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        Console.WriteLine(EvaluateExpression(expression));
    }
}
