using System;
using System.Collections.Generic;
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
            string Name = "51654ssdrtdf";
            string Letter = "";
            string Digit = "";
            int Num = 0;
            int let = 0;    
            foreach(char c in Name)
            {
                if (Char.IsDigit(c))
                {
                    Digit += c;
                    Num++;  
                }
                else if (Char.IsLetter(c))
                {
                    Letter += c;
                    let++;
                }
            }
            Console.WriteLine($"Total Digit in String is {Num} is As Follow {Digit}");
            Console.WriteLine($"Total Letter in String is {let} is As Follow {Letter}");


        }
    }
}
