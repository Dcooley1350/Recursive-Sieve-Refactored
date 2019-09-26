using System;
using System.Collections.Generic;

namespace Sieve.Maths
{
    public class Backend
    { 
        public static void RecursiveSieve(int[] array, int prime)
        {
            // foreach (int number in array)
            for (int i = 0; i < array.Length; i++ )
            {
                if ( array[i] != prime)
                {
                    if (array[i] % prime == 0)
                    {
                        array[i] = 0;
                    }
                }
            }
            prime++;
            if (prime< array.Length)
            {
            RecursiveSieve(array, prime);
            }
        }
    }
}











// foreach (int number in userArray)
// {
//     for (int i = number + 1; i < userNumber; i++)
//     {
//         if (i % number == 0)
//         {
//             Console.WriteLine(number);
//             userArray[number] = 0;
//         }
//     }
// }

// for (int prime = 2; prime < userNumber; prime++)
// {
//     foreach (int number in userArray)
//     {
//         if (number % prime == 0)
//         {
//             Console.WriteLine(number);
//             userArray[number] = 0;
//         }
//     }
// }
