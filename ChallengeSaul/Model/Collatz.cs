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
        int number;
        int par_count;
        int impar_count;
        int count = 0;
        //Data to graph
        List<int> x_axis = new List<int>();
        List<int> y_axis = new List<int>();
        //////////////////////////////////////
        
        //Function to giving a value to the object attributes
        public void number_collatz(int n)
        {
            
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
            x_axis.Add(count);
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

                count = count + 1;
                y_axis.Add(n);
                x_axis.Add(count);
            }

        }


    }
}
