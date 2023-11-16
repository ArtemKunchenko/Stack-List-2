using System;
using System.Xml.Linq;


namespace Stack__List_
{
    public class Stack<T>
    {
        private List<T> Data { get; set; }
        public int Capasity { get; set; }
        public Stack(int capasity)
        {
            Data = new List<T>();
            Capasity = capasity;
        }
        public void Clear() { Data.Clear(); }//Delete whole elements in the Stack
        public bool Contains(T data)//Determines whether an item is in the Stack 
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (Equals(Data[i], data)) return true;
            }
            return false;
        }
        public bool Empty()//Checking of empty stack
        {
            if (Data.Count == 0) return true;
            else return false;
        }
        public int GetSize() { return Data.Count; }//Return size of Stack
        public T this[int index] //Iterator
        {
            get
            {
                if (index < 0 || index >= Data.Count) { throw new ArgumentOutOfRangeException(nameof(index)); }
                else return Data[index];
            }
            set
            {
                if (index < 0 || index >= Data.Count) { throw new ArgumentOutOfRangeException(nameof(index)); }
                Data[index] = value;
            }
        }
        public void Push(T data) //Add elemrnt to the end of Stack
        {
            if (Data.Count < Capasity) Data.Add(data);
            else Console.WriteLine("Error. Stack overflow!");
        }
        public T Pop()//Return the last element from Stack an delete it
        {
            T temp = Data[Data.Count - 1];
            Data.Remove(Data.Count - 1);
            return temp;
        }
        public T Peek()//Return the last element from Stack without deletion
        {
            T temp;
            if (Data.Count != 0) { temp = Data[Data.Count - 1]; }
            else temp = default;
            return temp;
        }
        public T[] ToArray()//Copy elements from Stack to Array
        {
            T[] array = new T[Data.Count];
            for (int i = 0; i < Data.Count; i++)
            {
                array[i] = Data[i];
            }
            return array;
        }
    }
}
