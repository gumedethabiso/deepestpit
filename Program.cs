using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class DeepestPitAnswer /*function instructed to open*/
    {
        public static int solution(int[] points)
        {
            int inx = new int[] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };   /* creating the array*/

            var solution = new DeepPitSolution();                     /*declaring the solution*/
            var outcome = solution.Solution(inx);                     /* assigning the outcome to the solution variable*/

            assert.AreEqual(4, outcome);

            if (!HasTriplet(points))                                   /* if function to check if there is a possible bit or 3 numbers in the array*/
            {
                return -1;
            }

            int P = inx[0], Q = P, R;                                  /*initializing the points of the depth of the pit */

            int down = -1;                                             /* this is the depth from the highest point*/
            int upward = -1;                                           /* the lengty from the bottok of the pit*/

            for (int x = 0; x < points.Length; x++ )                   
            {                 
                if (x + 1 >= points.Length)                            /* this loop prevents the occurance of an error when the slope reaches the lowest point */
                {
                    return upward;          
                }
            }

            public bool HasTriplet(int[] point)                             /*Function to check if there are 3 integers in the array*/
            {
                if (A.Length >= 3)
                {
                    return true;
                }

                return false;
            }
        }

    }
}
