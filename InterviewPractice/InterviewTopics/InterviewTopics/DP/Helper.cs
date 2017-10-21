using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics.DP
{
    static class Helper
    {
        public static int minValue(int x, int y, int z)
        {
            if (x < y && x < z)
                return x;
            if (y < x && y < z)
                return y;
            return z;
        }

        public static int maxValue(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
