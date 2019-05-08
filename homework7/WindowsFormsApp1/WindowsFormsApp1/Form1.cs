using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Order> L = new List<Order>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Order O = new Order();
            O.id = intern.O.id;
            O.name = intern.O.name;
            O.client = intern.O.client;
            bool flag = true;
            foreach (Order order in L)
            {
                if (order.id == O.id)
                {
                    flag = false;
                    break;
                }

            }
            if (flag == false)
            {
                MessageBox.Show("插入失败，不能重复插入相同编号的订单");
            }
            else
            {
                MessageBox.Show("插入成功");
                L.Add(O);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int k = 0;
            foreach(Order order in L)
            {
                textBox1.AppendText(order.ToString()+'\n');
               
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Order O = new Order();
            O.id = intern.O.id;
            O.name = intern.O.name;
            O.client = intern.O.client;
            bool flag = false;
            foreach (Order order in L)
            {
                if (order.id == O.id)
                {
                    order.client = O.client;
                    order.name = O.name;
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                MessageBox.Show("修改失败，不存在此编号的订单");
            } else MessageBox.Show("修改成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox2.Text);
            bool flag = false;
            foreach (Order order in L)
            {
                if (order.id == k)
                {
                    MessageBox.Show(order.ToString());
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                MessageBox.Show("查询失败!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int k = int.Parse(textBox2.Text);
            foreach (Order order in L)
            {
                if (order.id == k)
                {
                    L.Remove(order);
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                MessageBox.Show("删除失败！");
            }
            else MessageBox.Show("删除成功！");
        }
    }

}
