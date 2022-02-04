using System;

namespace sortering_uppg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           

            int[] arr = new int[100];

            for (int i = 0; i < 99; i++)
            {
                arr[i] = rnd.Next(1,100);
            }

            foreach (int e in arr)
            {
               Console.WriteLine(arr[e]); 
            }
            

            
        }
    }
}
