using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW3_list_
{
    class MyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count = 0;



        private class Node<T>
        {
            public T value;
            public Node<T> prev;
            public Node<T> next;
            public Node(T value)
            {
                this.value = value;
            }
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head == null)
                head = node;
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            Node<T> temp = head;
            node.next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.prev = node;
            count++;
        }

        public bool Contains(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(value))
                    return true;
                current = current.next;
            }
            return false;
        }
        public void Remove(T value)
        {
            Node<T> current = head;


            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    break;
                }
                current = current.next;
            }
            if (current != null)
            {

                if (current.next != null)
                {
                    current.next.prev = current.prev;
                }
                else
                {

                    tail = current.prev;
                }


                if (current.prev != null)
                {
                    current.prev.next = current.next;
                }
                else
                {

                    head = current.next;
                }
                count--;

            }
        }
        public void RemoveFirst()
        {

            head = head.next;


        }


        public bool IsEmpty()
        {
            if (count > 0)
            {
                return false;
            }
            else return true;
        }
        public T Peek()
        {

            return tail.value;

        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }
        public IEnumerator<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.value;
                current = current.prev;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
