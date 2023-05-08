using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Solution
    {
        public void Number()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            int Num = 0;    
            foreach(char iteam in Name)
            {
                Num++;  
            }
            Console.WriteLine(Num); 

        }
        
    }
}
