using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Stack_Queue_LinkedList__Algorthim
{
    class Stack
    {
        // const size
        const int Max_Size = 100;
        int top;
        int[] item = new int[Max_Size];

        public Stack()
        {
            top = -1;
        }
        Boolean IsFull()
        {
            if (top >= Max_Size - 1)
                return true;
            else
                return false;
        }
        public void push(int Element)
        {
            if (IsFull())
                Console.WriteLine("Stack Is Full!!");
            else
                item[++top] = Element;
        }
        Boolean IsEmpty()
        {
            return top < 0;
        }
        public void Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Stack Is Empty!!");
            else
                top--;
        }
        public int GetFirstElement(out int Value)
        {
            Value = item[top];
            return Value;
        }
        public void Print()
        {
            Console.Write("[");
           for(int i = 0; i <= top; i++)
            {
                Console.Write(item[i]);
                if (i == top)
                    continue;
                Console.Write(",");
            }
            Console.Write("]");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(12);
            stack.push(120);
            stack.push(1200);
            stack.push(1200);
            stack.push(12000);
            stack.push(120000);
            stack.Print();
            Console.WriteLine();
        }
    }
}
