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
            listSysCall.Add(new SysCall(1, "Принтер", new List<Arg> { new Arg("ardress", "string"), new Arg("object", "xml") }));
            listSysCall.Add(new SysCall(2, "Экран", new List<Arg> { new Arg("second", "int") }));
            listSysCall.Add(new SysCall(3, "Мышь", new List<Arg> { new Arg("third", "char") }));
            listSysCall.Add(new SysCall(4, "Клавиатура", new List<Arg> { new Arg("fourth", "bool") }));
            listSysCall.Add(new SysCall(5, "Что-то", new List<Arg> { new Arg("fifth", " long") }));
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
            Arg arg = stack.Pop();
            int a = 0;
            foreach (SysCall element in listSysCall)
            {
                foreach (Arg ar in element.Args)
                {
                    if ((element.ID == id) && (ar.Name == arg.Name) && (ar.Type == arg.Type))
                    {
                        Console.WriteLine("Правильный системный вызов");
                        Console.WriteLine("Arg: ID = " + id + ", Name = " + arg.Name + ", Type = " + arg.Type + ", Value = " + arg.Value);
                        Console.WriteLine();
                        return;
                    }
                    if ((element.ID != id) && (ar.Name == arg.Name) && (ar.Type == arg.Type))
                    {
                        Console.WriteLine("Ошибка в ID");
                        Console.WriteLine("Arg: ID = " + id + ", Name = " + arg.Name + ", Type = " + arg.Type + ", Value = " + arg.Value);
                        Console.WriteLine();
                        return;
                    }
                    if ((element.ID == id) && ((ar.Name != arg.Name) || (ar.Type != arg.Type)))
                    {
                        Console.WriteLine("Ошибка в аргументах");
                        Console.WriteLine("Arg: ID = " + id + ", Name = " + arg.Name + ", Type = " + arg.Type + ", Value = " + arg.Value);
                        Console.WriteLine();
                        return;
                    }
                    else a++;
                    if (a == 5)
                    {
                        Console.WriteLine("Ошибка");
                        return;
                    }
                }              
            }
        }
    }
}
