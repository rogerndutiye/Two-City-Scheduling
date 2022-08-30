using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCityFlyingCost
{
    public class SchedCost
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            
            //Sorting according to the biggest difference between cost of A and cost of B
            Array.Sort(costs, (a,b) => { return (a[0]-a[1]).CompareTo(b[0]-b[1]); });

            int minimumCost = 0;
            for (int i = 0; i < costs.Length; i ++)
            {
                if ( i < costs.Length / 2)
                    minimumCost += costs[i][0];
                else
                    minimumCost += costs[i][1];
            }
            return minimumCost;
        }
    }
}