using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_num_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out odd numbers from 1 through 99 inclusive
            //start at 1, make condition less than or =99. add 2 after each loop
            int counter;
            for (counter = 1; counter <=99; counter += 2)
            {
                Console.WriteLine(counter);
            }

        }
    }
}
