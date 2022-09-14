using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Kernel
    {
        public List<SysCall> listSysCall;
        public Kernel() {
            listSysCall = new List<SysCall>();
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
        public void Call(int id, MyStack<Arg> stack)
        {
            Arg arg = stack.Peek();
            int a = 0;
            foreach (SysCall element in listSysCall)
            {
                foreach (Arg ar in element.Args)
                {
                    if ((element.ID == id) && (ar.Name == arg.Name) && (ar.Type == arg.Type) && (ar.Value == arg.Value))
                    {
                        Console.WriteLine("Arg: ID = " + id + ", Name = " + arg.Name + ", Type = " + arg.Type + ", Value = " + arg.Value);
                        Console.WriteLine();
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
}
