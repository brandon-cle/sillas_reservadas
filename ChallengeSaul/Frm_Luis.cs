﻿using System;
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
    public partial class Frm_Luis : Form
    {
        public Frm_Luis()
        {
            InitializeComponent();
            nudNumero.Maximum = Int32.MaxValue;
        }
    }
}
