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
            int[] Array = { 10, 20, 30, 40, 50, 60 };
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i] + " ");
        }
    }
}
