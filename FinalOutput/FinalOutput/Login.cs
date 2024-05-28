using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOutput
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm form2 = new RegForm();
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home form3 = new Home();
            this.Hide();
            form3.Show();

         
        }
        }
    }

