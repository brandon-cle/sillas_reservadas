using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChallengeSaul.Controller;
using ChallengeSaul.User_Control;

namespace ChallengeSaul
{
    public partial class Form1 : Form
    {
       
        public static uc_seat[] uc_SeatsA = new uc_seat[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void populateitem()
        {

            
            DataTable data_chair = new DataTable();
            data_chair = CSeat.ShowChairA();
            
            for (int i = 0; i < uc_SeatsA.Length; i++)
            {
                
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                {

                    uc_SeatsA[i] = new uc_seat();
                    uc_SeatsA[i].info_seat(data_chair.Rows[i][0].ToString(), data_chair.Rows[i][1].ToString(), data_chair.Rows[i][2].ToString());

                    Console.WriteLine(data_chair.Rows[i][0].ToString() + " " + data_chair.Rows[i][1].ToString() + " " + data_chair.Rows[i][2].ToString());
                    flowLayoutPanel1.Controls.Add(uc_SeatsA[i]);
                }
            }


            


            //for (int i = 0; i < uc_Seats.Length; i++)
            //{
            //    uc_Seats[i] = new uc_seat();
            //    if (flowLayoutPanel1.Controls.Count < 0)
            //    {
            //        flowLayoutPanel1.Controls.Clear();
            //    }
            //    {
            //        flowLayoutPanel1.Controls.Add(uc_Seats[i]);
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateitem();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            show.ShowDialog();
        }
    }
}
