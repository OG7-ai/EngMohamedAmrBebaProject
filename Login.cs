using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohamed_Beba_Project
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90 ));
            pictureBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90));

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user123" && textBox2.Text == "user123"))
            {
                TotalSells form1 = new TotalSells();
                form1.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "admin" && textBox2.Text == "password"))
            {
                AdminDashboard form1 = new AdminDashboard();
                form1.Show();
                this.Hide();


            }
            //else
            //{
            //    MessageBox.Show("اسم المستخدم او كلمه المرور خطأ \n اعد المحاوله ");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user123" && textBox2.Text == "user123"))
            {
                TotalSells form1 = new TotalSells();
                form1.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "admin" && textBox2.Text == "password"))
            {
                AdminDashboard form1 = new AdminDashboard();
                form1.Show();
                this.Hide();


            }
            //else
            //{
            //    MessageBox.Show("اسم المستخدم او كلمه المرور خطأ \n اعد المحاوله ");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user123" && textBox2.Text == "user123"))
            {
                TotalSells form1 = new TotalSells();
                form1.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "admin" && textBox2.Text == "password")) {
                AdminDashboard form1= new AdminDashboard();
                form1.Show();
                this.Hide();
            
            
            }
            //else {
            //    MessageBox.Show("اسم المستخدم او كلمه المرور خطأ \n اعد المحاوله ");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //}
        }
    }
}
