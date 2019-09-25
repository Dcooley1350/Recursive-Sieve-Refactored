using System;
using System.Collections.Generic;

namespace maths.backend
{
    class Sieve
    { 
        public static void RecursiveSieve(int[] array, int prime)
        {
            foreach (int number in array)
            {
                if (number % prime == 0)
                {
                    array[number] = 0;
                }
            }
            prime++;
            RecursiveSieve(array, prime);
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
