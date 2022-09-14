using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Kernel
    {
        public List<SysCall> listSysCall;
        public Kernel() {
            listSysCall = new List<SysCall>();
            int a = 1;
            listSysCall.Add(new SysCall(1, "Принтер", new List<Arg> { new Arg("first", "Устройство вывода", 400)}));
            listSysCall.Add(new SysCall(2, "Экран", new List<Arg> { new Arg("first", "Устройство вывода", 401) }));
            listSysCall.Add(new SysCall(3, "Мышь", new List<Arg> { new Arg("first", "Устройство ввода", 402) }));
            listSysCall.Add(new SysCall(4, "Клавиатура", new List<Arg> { new Arg("first", "Устройство ввода", 403) }));
            listSysCall.Add(new SysCall(5, "Что-то", new List<Arg> { new Arg("first", "Какой-то", 404) }));
        }
        public void ShowAll() {
            foreach (SysCall element in listSysCall) {
                Console.WriteLine(element.ID + " " + element.Name);
                foreach (Arg ar in element.Args) {
                    Console.WriteLine("Arg: Name = " + ar.Name + " Type = " + ar.Type);
                    Console.WriteLine();
                }
            }        
        }
        public void Call(int id, MyStack<int> stack)
        {
            //Добавляем новые элементы в стек.
            stack.Push(id);
            //Получаем элементы с удалением.
            var item1 = stack.Pop();
            //Console.WriteLine($"Верхний элемент {item1}.");
            //Console.ReadLine();
            int a = 0;
            foreach (SysCall element in listSysCall)
            {
                if (element.ID == item1)
                {
                    Console.WriteLine(element.ID + " " + element.Name + " Правильный вызов");
                    foreach (Arg ar in element.Args)
                    {
                        Console.WriteLine("Arg: Name = " + ar.Name + " Type = " + ar.Type);
                        Console.WriteLine();
                    }
                    return;
                }
                else a++;
                if (a == 5)
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }
    }
}
