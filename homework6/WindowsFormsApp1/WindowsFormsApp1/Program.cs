using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp1
{

    public class Order : IComparable
    {
        public int id;
        public string client;
        public string name;
        public Order()
        {
            id = 0;
            client = "";
            name = "";
        }
        public int CompareTo(object m)
        {
            Order O = (Order)m;
            if (id > O.id) return 1; else return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj is Order)
            {
                Order m = (Order)obj;
                if (m.client == client && m.id == id && m.name == name) return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "订单编号为" + id + "客户名为" + client + "商品名为" + name;
        }
        public Order(int _id, string _client, string _name)
        {
            this.id = _id;
            this.client = _client;
            this.name = _name;
        }
        public void print()
        {
            Console.WriteLine("订单编号为" + id + "客户名为" + client + "商品名为" + name);
            Console.WriteLine();
        }
    }

    public class intern
    {
        static public Order O = new Order();
    }


    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();
            Application.Run(form1);
        }
    }
}
