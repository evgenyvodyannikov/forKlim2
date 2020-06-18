using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Method(int first, int second, int three, out int max)
        {
            max = 0;
            int min = 0;
            min = first;
            if (second < min)
            { min = second; }
            if (three < min)
            { min = three; }
            for (int i = 1; i <= min; i++)
            {
                if (first % i == 0 && second % i == 0 && three % i == 0)
                { max = i; }
            }
            return max;
        }
    }
}
