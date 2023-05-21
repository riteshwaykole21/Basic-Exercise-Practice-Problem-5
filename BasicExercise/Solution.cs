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
            int[] Array = { 10, 20, 50, 70, 100, 55, 12 };
            int[] array = new int[10];
            for(int i = 0; i < Array.Length; i++)
            {
                array[i] = Array[i];
                Console.Write(array[i] + " ");
            }
        }
         
    }
}
