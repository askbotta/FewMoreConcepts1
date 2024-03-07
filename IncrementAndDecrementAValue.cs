using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FewMoreConcepts1
{
    public class IncrementAndDecrementAValue
    {
        public void IncrementAndDecrementAValue1()
        {
            int Value = 1;
            Value = Value + 1;
            Console.WriteLine("First Increment: " + Value);

            Value += 1;
            Console.WriteLine("Sceond Increment:" + Value);

            Value++;
            Console.WriteLine("Third Increment: " + Value);

            ++Value;
            Console.WriteLine("Pre Increment: " + Value);


        }
    }
}
