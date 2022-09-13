using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kernel kernel = new Kernel();
            kernel.ShowAll();
            // Создаем новый стек.
            // Создаем новый стек.
            var stack = new MyStack<int>();
            kernel.Call(1);
            kernel.Call(2);
            kernel.Call(3);
            kernel.Call(4);
            kernel.Call(5);
            kernel.Call(6);

            Console.ReadLine();
        }
    }
}
