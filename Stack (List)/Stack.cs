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

    }
}
