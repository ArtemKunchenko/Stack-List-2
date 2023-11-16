using System;


namespace Stack__List_
{
    public class Stack<T>
    {
        private List<T> Data{ get; set; }
        public int Capasity {  get; set; }
        public Stack(int capasity) 
        {
            Data = new List<T>();   
            Capasity = capasity;
        }
        public void Clear() { Data.Clear(); }//Delete whole elements in the Stack
        public bool Contains(T data)//Determines whether an item is in the Stack<T> 
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (Equals(Data[i], data)) return true;
            }
            return false;
        }

    }
}
