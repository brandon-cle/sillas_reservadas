using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSaul.Model
{
    class Collatz
    {
        //Making object, finally it's an object
        public static int number;
        public static int par_count;
        public static int impar_count;
        public static int count;
        //Data to graph
        public static List<int> y_axis = new List<int>();
        //////////////////////////////////////
        
        //Function to giving a value to the object attributes 
        public static void number_collatz(int n)
        {
            par_count = 0;
            impar_count = 0;
            y_axis.Clear();
            #region validating detail
            //just postive numbers
            if (n < 1)
            {
                return;
            }
            #endregion
            number = n;
            //First number to start
            y_axis.Add(n);
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    par_count++;
                }
                else
                {
                    n = 3 * n + 1;
                    impar_count++;
                }
                y_axis.Add(n);
            }
            count = par_count + impar_count;
        }
    }
}
