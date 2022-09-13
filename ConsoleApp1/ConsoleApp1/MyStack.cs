using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Стек
    /// </summary>
    /// <typeparam name="T"> Тип данных, хранимых в стеке. </typeparam>
    public class MyStack<T>
    {
        /// <summary>
        /// Коллекция хранимых данных.
        /// </summary>
        private List<T> _items = new List<T>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Добавить данные в стек.
        /// </summary>
        /// <param name="item"> Добавляемые данные. </param>
        public void Push(T item)
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Добавляем данные в коллекцию элементов.
            _items.Add(item);
        }

        /// <summary>
        /// Получить верхний элемент стека с удалением.
        /// </summary>
        /// <returns> Элемент данных. </returns>
        public T Pop()
        {
            // Получаем верхний элемент.
            var item = _items.LastOrDefault();

            // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }

            // Удаляем последний элемент из коллекции.
            _items.RemoveAt(_items.Count - 1);

            // Возвращаем полученный элемент.
            return item;
        }

        /// <summary>
        /// Прочитать верхний элемент стека без удаления.
        /// </summary>
        /// <returns> Элемент данных. </returns>
        public T Peek()
        {
            // Получаем верхний элемент.
            var item = _items.LastOrDefault();

            // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }

            return item;
        }
    }
}