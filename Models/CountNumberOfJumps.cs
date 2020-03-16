using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class CountNumberOfJumps
    {
        public int Steps { get; set; }

        public int User_Ans { get; set; }
        public CountNumberOfJumps()
        {

        }
        public CountNumberOfJumps(int Steps, int User_Ans)
        {
            this.Steps = Steps;
            this.User_Ans = User_Ans;
        }
        public int FindNumberOfJumps(int steps)
        {
            //code
            int i;
            int[] a = new int[steps];
            a[0] = 1;
            a[1] = 2;
            a[2] = 4;
            for (i = 3; i < steps; i++)
            {
                a[i] = a[i - 1] + a[i - 2] + a[i - 3];
            }

            return a[steps - 1];

        }
    }
}