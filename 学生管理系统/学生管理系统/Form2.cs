using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 学生信息表BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.学生信息表BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lzs1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“lzs1DataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.lzs1DataSet.学生信息表);

        }
        //插入学生信息
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            conn.Open();
            // Console.WriteLine("已建立连接");
            //string constr = "Data Source=(local);Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            //SqlConnection conn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter();
            string sql = "select * from 学生信息表";
            da.SelectCommand = new SqlCommand(sql, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow NewRow = ds.Tables[0].NewRow();
            NewRow["学号"] = comboBox1.Text;
            NewRow["姓名"] = comboBox2.Text;
            NewRow["性别"] = comboBox3.Text;
            NewRow["出生年月"] = comboBox4.Text;
            NewRow["地址"] = comboBox5.Text;
            NewRow["电话"] = comboBox6.Text;
           // NewRow["英语"] = comboBox7.Text;
            ds.Tables[0].Rows.Add(NewRow);
            da.Update(ds);
            conn.Close();
            MessageBox.Show("录入成功");
        }

        //修改信息模块
        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            conn.Open();
            //string MyConn = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            //SqlConnection MyConnection = new SqlConnection(MyConn);
            SqlDataAdapter da = new SqlDataAdapter();
            string MyUpdate = "select * from 学生信息表 where 学号 ='" + comboBox1.Text + "'";
            //SqlDataAdapter da = new SqlDataAdapter(MyUpdate, conn);
            da.SelectCommand = new SqlCommand(MyUpdate, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow MyRow = ds.Tables[0].Rows[0];
            MyRow["姓名"] = comboBox2.Text;
            MyRow["性别"] = comboBox3.Text;
            MyRow["出生年月"] = comboBox4.Text;
            MyRow["地址"] = comboBox5.Text;
            MyRow["电话"] = comboBox6.Text;
            // ds.Rows.Add(MyRow);

            da.Update(ds);
            conn.Close();
            MessageBox.Show("修改成功");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        //删除信息模块
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            conn.Open();
            //string MyConn = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            //SqlConnection MyConnection = new SqlConnection(MyConn);
            SqlDataAdapter da = new SqlDataAdapter();
            string MyUpdate = "select * from 学生信息表 where 学号 ='"+comboBox1.Text+"'";
            //SqlDataAdapter da = new SqlDataAdapter(MyUpdate, conn);
            da.SelectCommand = new SqlCommand(MyUpdate, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow DelectRow = ds.Tables[0].Rows[0];
            DelectRow.Delete();
            da.Update(ds);
            conn.Close();
            MessageBox.Show("删除成功");
        }

        //查询信息的的模块
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-Q97SADN;Initial Catalog=lzs1;Integrated Security=True;Pooling=False";
            conn.Open();
             SqlDataAdapter da = new SqlDataAdapter();
             string MyUpdate = "select * from 学生信息表 where 学号 ='" + comboBox7.Text + "'";
             da.SelectCommand = new SqlCommand(MyUpdate, conn);
             SqlCommandBuilder scb = new SqlCommandBuilder(da);
             DataSet ds = new DataSet();
             da.Fill(ds);
             DataRow DelectRow = ds.Tables[0].Rows[0];
             comboBox2.Text = Convert.ToString(DelectRow["姓名"]);
             comboBox3.Text = Convert.ToString(DelectRow["性别"]);
             comboBox4.Text = Convert.ToString(DelectRow["出生年月"]);
             comboBox5.Text = Convert.ToString(DelectRow["地址"]);
             comboBox6.Text = Convert.ToString(DelectRow["电话"]);
             MessageBox.Show("查询成功");
             conn.Close();
           
            /*
            string MyUpdate = "select * from 学生信息表 where 学号 ='" + comboBox7.Text + "'";
            //SqlDataAdapter da = new SqlDataAdapter(MyUpdate, conn);
            da.SelectCommand = new SqlCommand(MyUpdate, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            DataRow DelectRow = ds.Tables[0].Rows[0];
            comboBox2.Text = Convert.ToString(DelectRow["姓名"]);
            MessageBox.Show("查询成功");
            conn.Close();*/
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
