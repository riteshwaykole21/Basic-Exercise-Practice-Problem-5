using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Class1
    {
        public void Number<T>(T[] str)
        {
            foreach(T t in str)
            {
                Console.WriteLine(t);
            }
        }
        
    }
}
