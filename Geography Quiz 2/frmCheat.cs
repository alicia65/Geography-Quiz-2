﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz_2
{
    public partial class frmCheat : Form
    {
        public frmCheat()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImLazy_Click(object sender, EventArgs e)
        {
            //display correct answer on the quiz form
            string answer;
            if (txtUserAnswer.Select == true) 
            {
                MessageBox.Show(answer);
                
            }
        }

        private void frmCheat_Load(object sender, EventArgs e)
        {

        }
    }
}