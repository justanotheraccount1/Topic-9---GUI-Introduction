using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___GUI_Introduction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnSubmit.Enabled = false;
            btnQuit.Visible = true;
            btnQuit.Enabled = true;
            btnSubmit.Text = "Thank You";
        }

       

       
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void lblIsntructor_DoubleClick(object sender, EventArgs e)
        {
            lblIsntructor.BackColor = Color.White;
            lblIsntructor.ForeColor = Color.Black;
        }
    }
}
