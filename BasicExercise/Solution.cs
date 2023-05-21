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
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[Size];
            Console.WriteLine("Enter The Array Element");
            for(int i = 0; i < Size; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " "); 
            }
        }
    }
}
