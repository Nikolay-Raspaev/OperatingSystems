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
            mystack.Push(new Arg("first", "Устройство вывода", 400));
            kernel.Call(1, mystack);
            kernel.Call(3, mystack);
            Console.ReadLine();
        }
    }
}
