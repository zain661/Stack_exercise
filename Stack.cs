using System;


namespace Stack
{
    class Stack1<T>
    {
        private T[] stack;
        private int top;
        private int max;

        public Stack1(int size)
        {
            stack = new T[size];
            top = -1;
            max = size;
        }

        public void Push(T element)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack OverFlow");
            }

            else
            {
                stack[++top] = element;
            }
        }

          public T Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                return stack[top--];
            }
        }

        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                
            }
            else
            {
                foreach (T item in stack)
                {
                    Console.WriteLine("the item: " +  item);
                }
            }
            
        }

        public T Peak()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                return stack[top];
            }

        }

        public void Clear()
        {
            top = -1;
        }

    }
}
