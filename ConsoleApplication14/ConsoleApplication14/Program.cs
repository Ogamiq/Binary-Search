using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {

        static void binarySearch(int[] numbers,int N,ref int startIndex, ref int endIndex)
        {
            int midPointIndex = ((endIndex + startIndex + 1 ) / 2);

            Console.ReadKey();
            Console.WriteLine("Value at midpoint index: " + numbers[midPointIndex] + "           Midpoint index: " + midPointIndex);
           


            if (numbers[midPointIndex] == N)
            {
                Console.WriteLine("\nSucess!");
                Console.WriteLine("I have found number {0} at the index {1} !", N, midPointIndex);
            }
            if (numbers[midPointIndex]<N)
            {
                startIndex = midPointIndex;
                binarySearch(numbers, N, ref startIndex, ref endIndex);
            }

            if(numbers[midPointIndex]>N)
            {
                endIndex = midPointIndex;
                binarySearch(numbers, N, ref startIndex, ref endIndex);
            }


        

        }



        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 5, 12, 13, 14, 16, 18, 19, 21, 31, 40, 51,122, 546, 876, 932, 1783, 2251};
            int N = 546;

            int startIndex = 0;
            int endIndex = numbers.Length - 1;

          
            Console.WriteLine("---------- binary search in progress -------------");
            Console.WriteLine("------- press space to go see the next step! -----\n");

            binarySearch(numbers, N,ref startIndex,ref endIndex);
            Console.ReadKey();

          
            //   binarySearch(numbers, N);
        }
    }
}

