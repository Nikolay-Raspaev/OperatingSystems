using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kernel kernel = new Kernel();
            kernel.ShowAll();
            MyStack<Arg> mystack = new MyStack<Arg>();

            mystack.Push(new Arg("object", "xml", 4125));
            kernel.Call(1, mystack);

            mystack.Push(new Arg("first", "int", 400));
            kernel.Call(3, mystack);

            mystack.Push(new Arg("third", "char", 402));
            kernel.Call(4, mystack);

            mystack.Push(new Arg("first", "bool", 409));
            kernel.Call(9, mystack);

            kernel.Call(9, mystack);
            Console.ReadLine();
        }
    }
}
