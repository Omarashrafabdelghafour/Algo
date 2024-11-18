using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class PROBLEM_CLASS
    {
        #region YOUR CODE IS HERE 

        //Your Code is Here:
        //==================
        /// <summary>
        /// Write a function to calculate the minimum work units for bread transportation among houses
        /// </summary>
        /// <param name="N">Number of houses in city </param>
        /// <param name="DemandPerHouse">Array containing bread demand per house </param>
        /// <returns>Minimum work units needed to destribute bread among neighbourhood</returns>
        static public Int64 RequiredFunction(int N, int[] DemandPerHouse)
        {
            Int64 totalWork = 0;
            Int64 bag_size = 0;
            for (int i = 0; i < N - 1; i++)
            {
                bag_size += DemandPerHouse[i];
                totalWork += Math.Abs(bag_size);
            }
            return totalWork;

        }


    }
}









#endregion