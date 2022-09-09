using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSR.components
{
    public class DoWhile1
    {
        public static void doWhile()
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;
            } while (i <= 20);
        }
    }
}
