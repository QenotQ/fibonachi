using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03_22
{
    internal class Fi
    {
        

        public static int[] fibonachi(int n)
        {

            int [] result = new int[n];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < n; i++)
            {
                result[i] += result[i - 1] + result[i - 2];
                

            }

            
            return result;


        }
        

        
    }
}
