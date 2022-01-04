using ChallengeSaul.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSaul.Controller
{
    class CSeat
    {
        public static DataTable ShowChairA()
        {
            return MSeatcs.ShowChairA();
        }

        public static void updating_chair(string grpID, string place)
        {
            MSeatcs.updating_chair(grpID, place);
        }
    }
}
