using System;


namespace Stack__List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Ivan");
            list.Add("Alex");
            list.Add("Jim");
            list.Add("Garry");
            list.Add("Stiv");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}\t"); 
                
            }
           Console.WriteLine(list.Count);
            list.Remove(4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}\t");
               
            }
            Console.WriteLine(list.Count);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
