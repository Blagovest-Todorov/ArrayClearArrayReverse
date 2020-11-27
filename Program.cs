using System;

namespace _13.ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3 };
            Array.Reverse(numbers); //changes the indexes of reverse way so it changes the order //
            //reversevely of the array  source elements
            //Array.Reverse(numbers);
            //Array.Reverse(); inverts the array elements upsidedown

            Array.Clear(numbers, 0, numbers.Length-2); //clears array elements and set the default value o;
            foreach (var item in numbers)   //clears fro  start index till end index specified ! 
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
