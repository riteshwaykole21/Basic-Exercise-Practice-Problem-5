using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Solution
    {
        public void Number()
        {
            Console.WriteLine("Enter The Size Of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            Console.WriteLine("Enter The Element of An Array");
            for(int i = 0; i < size; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("The Reverse Of Array is ");
            for(int i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }
}
