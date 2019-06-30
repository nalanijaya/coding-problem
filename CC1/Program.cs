using System;

namespace CC1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[] intArray = new int[] { 1, 2, 3, 4};
          
            string[] stringArray = new string[] { "nalani","osi", "amma"};
          
            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
            Console.ReadLine();
        }
        static void PrintArray<T>(T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
