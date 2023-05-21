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
            int sum = 0;
            Console.WriteLine("Enter The Element Of A Array");
            for(int i = 0; i < size; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            for( int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            Console.WriteLine($" The Sum of Array Element is : {sum}");
        }
    }
}
