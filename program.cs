using System;
using System.Collections.Generic;
using Sieve.Maths;

namespace Sieve.Maths
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter a Number:");
            int userNumber = int.Parse(Console.ReadLine());

            List<int> userList = new List<int> {};
            for (int i = 2; i <= userNumber; i++)
            {
                userList.Add(i);
            }
            int prime = 2;

            int[] userArray = userList.ToArray();
            
            Backend.RecursiveSieve(userArray, prime);

            foreach ( int primi in userArray)
            {
                if (primi > 0)
                {
                Console.WriteLine(primi);
                }
            }
        }
    }
}