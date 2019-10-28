using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_2._4
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            int getchickenlegs = chickens * 2;
            int getcowlegs = cows * 4;
            int getpiglegs = pigs * 4;
            return getchickenlegs + getcowlegs + getpiglegs;
        }
    }
}
