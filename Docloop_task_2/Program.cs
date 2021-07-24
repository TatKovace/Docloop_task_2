using System;

namespace Docloop_task_2
{
    class Program
    {
        /*
        Create a method in C# for reversing an array without using embedded C# or .NET reversing methods such as Array.Reverse(); 
        Complexity should be as small as possible.

        Example: arr = [2,7,-5,4]. Result = [4,-5,7,2]
         */

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 55, 6, 8, 4 };
            int[] reverse_numbers = Reverse(numbers);

            foreach (int i in reverse_numbers)
                Console.Write("{0}, ", i);
        }

        private static int[] Reverse(int[] my_array)
        {
            int[] reverse = new int[my_array.Length];
            int index = 0;
            for (int i = my_array.Length -1; i >= 0; i--)
            {
                reverse[index] = my_array[i];
                index++;
            }

            return reverse;
        }
    }
}
