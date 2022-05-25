using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoTask
{
    public class MyStack<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();
        public int Count
        {
            get
            {
                return LinkedList.Count;
            }
        }
        public bool Get(T item)
        {
            return LinkedList.Contains(item);
        }
        public bool IsEmpty()
        {
            return LinkedList.Count == 0 ? true : false;
        }
        public void Push(T item)
        {
            LinkedList.AddLast(item);
        }
        public T Pop()
        {
            var list = LinkedList.ToList();
            T lastValue = list[LinkedList.Count - 1];
            LinkedList.RemoveLast();
            return lastValue;
        }
        public T Peek()
        {
            var list = LinkedList.ToList();
            T lastValue = list[LinkedList.Count - 1];
            return lastValue;
        }
        public int Size()
        {
            return LinkedList.Count;
        }
        public void Display()
        {
            foreach (var item in LinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
