using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeSaul.User_Control
{
    public partial class uc_seat : UserControl
    {
        public string grpID = null;
        public string place = null;
        public string status = null;
        public uc_seat()
        {
            InitializeComponent();
        }

        public void info_seat(string grpID_c, string place_c, string status_c)
        {
            grpID = grpID_c;
            place = place_c;
            status = status_c;
            if(status == "Unavailable")
            {
                pbx_seat.BackColor = Color.FromArgb(253, 86, 13);
                pbx_seat.Enabled = false;
            }
        }

        private void pbx_seat_Click(object sender, EventArgs e)
        {
            pbx_seat.BackColor = Color.FromArgb(253, 86, 13);
            ckb_reserved.Checked = true;
            ckb_reserved.Visible = true;
           
            status = "Unavailable#";
        }

        private void ckb_reserved_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_reserved.Checked == false)
            {
                ckb_reserved.Visible = false;
                pbx_seat.BackColor = Color.FromArgb(192, 255, 192);
                status = "Available";

            }
        }
    }
}
