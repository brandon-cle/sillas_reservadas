using ChallengeSaul.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeSaul
{
    public partial class Show : Form
    {

        public JustInfo[] info = new JustInfo[50];
        public Show()
        {
            InitializeComponent();
        }
        private void whatreservation()
        {

        }
        private void Show_Load(object sender, EventArgs e)
        {
            //A
            for(int i = 0; i < Form1.uc_SeatsA.Length; i++)
            {
                if (Form1.uc_SeatsA[i].status == "Unavailable#")
                {
                    list_reservation.Text = list_reservation.Text + Form1.uc_SeatsA[i].grpID + Form1.uc_SeatsA[i].place + "\n";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Form1.uc_SeatsA.Length; i++)
            {
                if (Form1.uc_SeatsA[i].status == "Unavailable#")
                {
                    CSeat.updating_chair(Form1.uc_SeatsA[i].grpID, Form1.uc_SeatsA[i].place);
                }

            }
        }
    }
}
