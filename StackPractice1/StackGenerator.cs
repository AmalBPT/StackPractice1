using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace StackPractice1
{
    class StackGenerator
    {
        public static Stack<int> GenerateRandomStack (int count = 25, int start = 1, int end = 50)
        {
            Random r = new Random();
            Stack<int> temp = new Stack<int>();
            for (int i =0; i < count; i++)
            {
                temp.Push(r.Next(start, end + 1));
            }
            return temp;
        }
        private static Stack<int> Clone (Stack<int> s)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> cloned = new Stack<int>();
            while (!s.IsEmpty())
                temp.Push(s.Pop());
            while (!temp.IsEmpty())
            {
                s.Push(temp.Top());
                cloned.Push(temp.Pop());
            }
            return cloned;
        }
        public static void PrintStack(Stack<int> s)
        {
            Stack<int> temp = Clone(s);
            Console.Write("[");
            if (!temp.IsEmpty())
                Console.Write(temp.Pop());
            while (!temp.IsEmpty())
            {
                Console.Write($", {temp.Pop()}");
            }
            Console.WriteLine("]");
        }
    }
}
