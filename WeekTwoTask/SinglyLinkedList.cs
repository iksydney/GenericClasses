using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoTask
{
    public class ListNode<T>
    {
        public ListNode<T> next;
        public T item;

        public ListNode(T item)
        {
            this.item = item;
            this.next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        public int Count { get; set; }

        public ListNode<T> head = null;
        
        public int Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            ListNode<T> temp = head;
            node.next = null;

            if(head == null)
            {
                node.next = head;
                head = node;
                Count++;
                
                return Count;
            }

            if(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Count++;
            return Count;
        }

        public bool Remove(T item)
        {
            ListNode<T> temp = head;
            ListNode<T> previous = null;
            if(Equals(temp, item))
            {
                head = temp.next;
                return true;
            }
            if(temp != null)
            {
                if(Equals(temp.item, item))
                {
                    previous.next = temp.next;
                    return true;
                }
                previous = temp;
                temp = temp.next;
            }
            return false;
        }

        public bool Check(T item)
        {
            ListNode<T> temp = head;
            if (temp != null)
            {
                if (Equals(temp.item, item))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public int Index(T item)
        {
            int Count = 0;
            ListNode<T> temp = head;
            if(temp != null)
            {
                if(Equals(temp.item, item))
                {
                    return Count;
                }
                Count++;
            }
            return Count;
        }
        public void Display()
        {
            ListNode<T>? temp = head;
            while ( temp != null)
            {
                Console.Write(temp.item + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
