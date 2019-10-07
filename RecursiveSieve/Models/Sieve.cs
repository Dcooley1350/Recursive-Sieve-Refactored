using System;
using System.Collections.Generic;

namespace Sieve.Maths
{
    public class Magic

    { 
        public static void RecursiveSieve(int[] array, int prime)
        {

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











