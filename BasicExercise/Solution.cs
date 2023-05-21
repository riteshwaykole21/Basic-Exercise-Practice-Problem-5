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
            int count = 0;
            int[] Array = { 10, 20, 30, 40, 50, 60, 10, 50, 60 };
            int index = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        count++;
                    }
                }
            }
            int[] arr = new int[count];
            for (int i = 0; i < Array.Length; i++)
            {
                for(int j = i + 1; j < Array.Length; j++)
                {
                    if(Array[i] == Array[j])
                    {
                         arr[index] = Array[j]; 
                         index++;
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.Write(count);
        }
    }
}
