using System;


namespace Stack__List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> ex = new Stack<string>(100);

            //Console.WriteLine(ex.Empty());
            ex.Push("Ivan");
            ex.Push("Alex");
            ex.Push("Jim");
            ex.Push("Garry");
            ex.Push("Stiv");
            
            //Console.WriteLine(ex.Empty());
            //for (int i = 0; i < ex.GetSize(); i++)
            //{
            //    Console.Write($"{ex[i]}\t");

            //}
            //string el= ex.Pop();
            //Console.WriteLine();
            //for (int i = 0; i < ex.GetSize(); i++)
            //{
            //    Console.Write($"{ex[i]}\t");

            //}
            string[] arr=ex.ToArray();
            foreach (string s in arr) { Console.WriteLine($"{s}\t"); }
            Console.WriteLine();
            //Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
