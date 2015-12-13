using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample
{
    public class Calculator
    {
        //Ham cua A viet
        public int Cong(int a, int b)
        {
            return a + b;
        }



        //Ham cua B viet
        public int Nhan(int a, int b)
        {
            if (b == 0)
                return 0;

            int res = 0;
            for (int i = 0; i < Math.Abs(b); i++)
            {
                //Su dung ham cua A
                res = Cong(res, a);
            }

            if (b < 0)
                return res * -1;
            return res;
        }
    }
}
