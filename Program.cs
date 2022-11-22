using System;
using System.Collections.Generic;

namespace HW3_list_
{
   class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            //Время вставки O(1)
            //Время удаление с середины O(1)
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.Push(1);
            linkedList.Push(2);
            linkedList.Push(3);
            linkedList.AddFirst(4);
            linkedList.RemoveFirst();



            foreach (int l in linkedList)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine(linkedList.Contains(1));
            Console.WriteLine(linkedList.IsEmpty());
            Console.WriteLine(linkedList.Peek());
            linkedList.Clear();
            Console.WriteLine(linkedList.IsEmpty());

            Console.WriteLine("\n\nList");
            //Время вставки O(1)
            //Время удаление с середины O(n)
            MyList<int> list = new MyList<int>();
            list.Add(8);
            list.Add(3);
            list.Add(1);
            list.Add(5);
            list.Add(3);
            list.Add(5);
               
            list.Add(5);
            list.Add(6);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            Console.WriteLine("\n");
            Console.WriteLine(list[2]);
            Console.WriteLine("\n");
            foreach (int l in list)
            {
                Console.WriteLine(l);
            }
            




             list.Insert(3, 10);
             Console.WriteLine(list[3]);
             Console.WriteLine(list.IsEmpty());
             list.Clear();
             Console.WriteLine(list.IsEmpty());










        }
    }
}
