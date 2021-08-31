using System;

namespace secondmaximumnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 2, 11, 15, 1, 7, 98, 3, 80, 4 };
            Array.Sort(array);   
            Array.Reverse(array);   
            Console.WriteLine("Second max Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " ");    
            }
        }
    }
}
