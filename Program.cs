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

            int P = inx[0], Q = P, R;                                  /*declaring the points of the depth of the pit */

            int down = -1;                                             /* this is the depth from the highest point*/
            int upward = -1;                                           /* the lengty from the bottok of the pit*/

            for (int x = 0; x < points.Length; x++)
            {
                if (x + 1 >= points.Length)                            /* this loop prevents the occurance of an error when the slope reaches the lowest point */
                {
                    return upward;
                }

                if (P < points[x + 1] && !R.HasValue)                        /* condition to check "p", the highest point on the slope*/
                {
                    P = points[x + 1];                                  /* setting the first or new highest point */
                    Q = points[x + 1];                                  /* setting the lowest or second point, "q" */
                    continue;                                           /* exits the loop earlier */
                }

                if (Q > points[x + 1])                                       /*condition to check "q", the lowest point or the second point*/
                {
                    Q = points[x + 1];
                    R = points[x + 1];
                    continue;
                }

                if (R < points[x + 1])                                       /* now that we have the first and second point, the next one is the third*/
                {
                    R = points[x + 1];

                    down = CalculateDepth(P.Value, Q.Value, R.Value);      /* getting the points to fet the values*/
                    upward = CompareDepths(upward, down);


                    //if it is set P to value of this so we can work out next slope
                    if ((x + 2) < points.Length && !(R < points[x + 2]))             /* checking if this is the highest point or  there is another element in the array */
                    {
                        P = R;
                    }
                }
                else
                {
                    P = R ?? P;                                                      /* setting the next point to start from  the previous slopes "p" */
                    Q = points[x + 1];                                               /* reseting the current slope "Q" to previous slopes' "p" */
                    R = null;                                                        /* not assigning a value to the"r" of the slope */
                }

                if (x + 2 == points.Length)                                          /* get the length of upward */
                {
                    return upward;
                }
            }
            return upward;                                                           /* returns if nothing runs as default "-1" */
        }
        public int CalculateDepth(int P, int Q, int R)
        {
            var outcome1 = P - Q;
            var outcome2 = R - Q;

            if (outcome1 < outcome2)
            {
                return outcome1;
            }
            else
            {
                return outcome2;
            }
        }

        public int CompareDepths(int upward, int down)
        {
            if (down > upward)
            {
                return down;
            }

            return upward;
        }
        public bool HasTriplet(int[] point)                             /*Function to check if there are 3 integers in the array*/
        {
            if (point.Length >= 3)
            {
                return true;
            }

            return false;
        }
    }
}
     
