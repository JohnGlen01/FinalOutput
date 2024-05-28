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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            MessageBox.Show("Successfully Logout.");
            form1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btndrinks_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = true;
            groupBox9.Visible = true;
            groupBox10.Visible = true;
            groupBox11.Visible = true;
            groupBox12.Visible = true;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void btndesserts_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = true;
            groupBox14.Visible = true;
            groupBox15.Visible = true;
            groupBox16.Visible = true;
            groupBox17.Visible = true;
            groupBox18.Visible = true;
        }
    }
}
