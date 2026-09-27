using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public static class ReglesRabais
    {
        public static decimal LimiterTotalAZero(decimal total)
        {
            if (total < 0)
            {
                total = 0;
            }
            return total;
        }
    }
}
