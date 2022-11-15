using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack1<int> s = new Stack1<int>(10);
            s.Push(1);
            s.Push(2);
            s.Pop();
            s.Print();


        }
    }
}
