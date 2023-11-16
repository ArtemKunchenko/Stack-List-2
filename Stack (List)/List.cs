using System;


namespace Stack__List_
{
    public class List<T>
    {
        private Node Head { get; set; }
        public int Count { get; set; }
        public List()
        {
            Count = 0;
            Head = null;

        }
        public void Add(T data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Count++;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Count++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) { throw new ArgumentOutOfRangeException(nameof(index)); }
                Node current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                if (index < 0 || index >= Count) { throw new ArgumentOutOfRangeException(nameof(index)); }
                Node current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Data = value;
            }
        }
        public void Insert(int index, T data)
        {
            if (index < 0 || index >= Count) { throw new ArgumentOutOfRangeException(nameof(index)); }
            Node newNode = new Node(data);
            if (index == 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            Count++;
        }
        public bool Remove(T data)
        {
            Node current = Head;
            Node previous = null;
            while (current != null)
            {
                if (Equals(current.Data, data))
                {
                    if (previous == null) { Head = current.Next; }
                    else { previous.Next = current.Next; }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        public bool Remove(int index)
        {
            if (index < 0 || index >= Count) { throw new ArgumentOutOfRangeException(nameof(index)); }

            if (index == 0)
            {
                if (Head != null)
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }
                return false; 
            }

            Node current = Head;
            Node previous = null;

            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    return false;
                }

                previous = current;
                current = current.Next;
            }

            if (current != null)
            {
                previous.Next = current.Next;
                Count--;
                return true;
            }

            return false; 
           
        }
        public void Clear()
        {
            if (Head != null)
            {
                Head = null;
                Count = 0;
            }

        }
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) { Data = data; }
        }
    }
}
