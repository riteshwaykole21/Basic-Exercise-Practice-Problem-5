using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution<int> sol = new Solution<int>();
            sol.Number(5);
            Solution<string> sol2 = new Solution<string>();
            sol2.Number("Five");

            Class1 sol12 = new Class1();
            int[] ints = { 10, 20, 30, 40, 50 };
            string[] strings = { "Ritesh", "Rushi" };
            sol12.Number<string>(strings);
            sol12.Number<int>(ints);
            
            Console.ReadLine();
        }
    }
}
