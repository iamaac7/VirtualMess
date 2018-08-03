using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMessManager
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
           
        }
        public ChangePassword(int userid)
        {
            InitializeComponent();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            textBox3.Focus();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox4;
            textBox4.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
