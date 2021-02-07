using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace StackPractice1
{
    class Program
    {
        static int Count (Stack<int> s)
        {
            //input : stack
            //output: how many elements in stack without changing stack
            throw new NotImplementedException();
        }
        static bool ValidExpression (string text)
        {
            //input: string of math expression (a+b) * c
            // output true if parentesis is valid else false
            throw new NotImplementedException();
        }
        static bool ValidExpressionWithDifferentParentesis(string text)
        {
            //input : string of math expression with different parentesis
            //output: string is a valid expression
            throw new NotImplementedException();
        }
        static bool Exists (Stack<int> stack, int x)
        {
            // input : stack and number 
            // output : if number exists in stack. stack is not changed
            throw new NotImplementedException();
        }
        static bool GetValueAt (Stack<int> stack, int place)
        {
            // input : stack and number
            //output: value in stack at number place.
            //assert there is a value at number place, and stack is not empty
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Stack<int> s = StackGenerator.GenerateRandomStack();
            StackGenerator.PrintStack(s);
            Console.WriteLine(Count(s));
            StackGenerator.PrintStack(s);
            string expression = "(a+b) * (c - d)";
            if (ValidExpression(expression))
                Console.WriteLine($"{expression} is valid");
            else
                Console.WriteLine($"{expression} is not valid");
            expression = "[(a-b] * c/d)";
            if (ValidExpressionWithDifferentParentesis(expression))
                Console.WriteLine($"{expression} is valid");
            else
                Console.WriteLine($"{expression} is not valid");
            Stack<int> st = StackGenerator.GenerateRandomStack(24);
            StackGenerator.PrintStack(st);
            Console.WriteLine("Get a number=>");
            int number = int.Parse(Console.ReadLine());
            if (Exists(st, number))
                Console.WriteLine($"the value {number} is in the stack");
            else
                Console.WriteLine($"the value {number} is not in the stack");
            Console.ReadKey();

        }
    }
}
