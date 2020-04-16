using System;
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
            this.Close();//leave cheat form
        }

        private void btnImLazy_Click(object sender, EventArgs e)
        {
            Tag = txtCheat.Text;// Provide user with answer
            
            DialogResult = DialogResult.OK;
            Close();
         
        }

        private void frmCheat_Load(object sender, EventArgs e)
        {
            txtCheat.Text = Tag.ToString();
        }

        private void lblCorrectAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
