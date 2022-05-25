using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoTask
{
    public class MyQueue<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();
        public int Count
        {
            get
            {
                return LinkedList.Count;
            }
        }
        public bool IsEmpty()
        {
            return LinkedList.Count == 0 ? true : false;
        }
        public void Enqueue(T item)
        {
            LinkedList.AddLast(item);
        }
        public T Dequeue()
        {
            var list = LinkedList.ToList();
            LinkedList.RemoveFirst();
            return list[0];
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
