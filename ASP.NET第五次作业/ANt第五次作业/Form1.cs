using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANt第五次作业
{
    public partial class Form1 : Form
    {
        //CheckBox[] interests = new CheckBox[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic );
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Strikeout);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // CheckBox ck = sender as CheckBox;
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = 12;
            size = Convert.ToInt32(comboBox2.SelectedItem);
            Font f = new Font(textBox1.Font.Name, size);
            this.textBox1.Font = f;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = "幼圆";
            t = Convert.ToString(comboBox1.SelectedItem);
            Font f = new Font(t,textBox1.Font.Size);
            this.textBox1.Font = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
