using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Solution
    {
        public void Number()
        {
            string Letter = "";
            string Digit = "";
            int a = 0;
            int b = 0;
            string Name = "21Ritesh";
            char[] Chars = Name.ToCharArray();
            for(int i = 0; i < Chars.Length; i++)
            {
                if(Char.IsDigit(Chars[i]))
                {
                     Digit += Chars[i];
                     a++;    
                }
                else if (Char.IsLetter(Chars[i]))
                {
                    Letter += Chars[i];
                    b++;
                }
            }
            Console.WriteLine(Digit);
            Console.WriteLine(Letter);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
