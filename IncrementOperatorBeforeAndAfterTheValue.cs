using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FewMoreConcepts1
{
    public class IncrementOperatorBeforeAndAfterTheValue
    {
        public void IncrementOperatorBeforeAndAfterTheValue1()
        {
            int value = 1;
            //value++;
            Console.WriteLine("First: "+ value);
            Console.WriteLine($"Scecond : {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
        }
    }
}
