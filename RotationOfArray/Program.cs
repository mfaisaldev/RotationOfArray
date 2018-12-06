using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int [] kl = new int[] { 3, 8, 9, 7, 6 };
            Solution sol = new Solution();
            int [] re = sol.Solution2(kl,3);
            foreach (var va in re)
            {
                Console.WriteLine(va);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
    class Solution
    {
        public int[] Solution1(int[] A, int K) // This will simply rotate the Array
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 1; i <= K; i++)
            {
                for (int l = 0; l < (A.Length/2); l++)
                {
                    int one = A[l];
                    int two = 0;
                    if (l!=0)
                    {
                        two = A[A.Length - (l+1)];
                        A[A.Length - (l+1)] = one;
                    }
                    else
                    {
                        two = A[A.Length - 1];
                        A[A.Length - 1] = one;
                    }
                    
                    A[l] = two;
                    
                }
            }
            return A;
        }

        public int[] Solution2(int[] A, int K) // This is Cyclic Rotating Array Solution
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int ix = 1; ix <= K; ix++)
            {
                int one = A[0];
                int two = A[A.Length - 1];
                for (int i = A.Length - 1; i > 0; i--) //starting from the end to begining
                {
                    A[i] = A[i - 1]; //assign value of the previous element
                }

                A[0] = two;

            }
            return A;
        }
    }
}
