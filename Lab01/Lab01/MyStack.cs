using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _items.Add(item);
        }
        public T Pop()
        {
            var item = _items.LastOrDefault();
            if (item == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Стэк пуст");
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }
            _items.RemoveAt(_items.Count - 1);
            return item;
        }
        public T Peek()
        {
            var item = _items.LastOrDefault();
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }
            return item;
        }
    }
}