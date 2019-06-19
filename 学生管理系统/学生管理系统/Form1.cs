using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zhanghao = "1712402602031";
            string password = "asdfghjkl";
            if((zhanghao == textBox1.Text) && (password == textBox2.Text)){
                MessageBox.Show("登录成功");
                Form2 a2 = new Form2();
                this.Hide();
                a2.Show();
            }
            else
            {
                MessageBox.Show("账号错误或密码错误！！！");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
