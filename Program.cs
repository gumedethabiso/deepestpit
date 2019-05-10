using System;

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


        }

    }
}
