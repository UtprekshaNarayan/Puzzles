using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class AllPossiblePaths
    {

        public int Length { get; set; }
        public int Breath { get; set; }
        public int TotalPossiblePaths { get; set; }
        public AllPossiblePaths()
        {

        }
        public AllPossiblePaths(int Length, int Breath, int TotalPossiblePaths)
        {
            this.Length = Breath;
            this.Length = Breath;
            this.TotalPossiblePaths = TotalPossiblePaths;
        }
        public int CountAllPossiblePaths(AllPossiblePaths ob)
        {
            int n = ob.Length;
            int m = ob.Breath;
            //m = 3;
            int[,] a = new int[n, m];
            int i, j;

            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    a[i, j] = 1;

            for (i = 1; i <= n - 1; i++)
            {
                for (j = 1; j <= m - 1; j++)
                    a[i, j] = (a[i - 1, j] + a[i, j - 1]) % 1000000007;
            }
            n = n - 1;
            //m = m;
            return a[n, m - 1];
        }
    }
}