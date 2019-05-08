using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace pp
{
    public class Order: IComparable
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

    public class OrderServices
    {
        private List<Order> L = new List<Order>();
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));

       

        public void Add()
        {
            Console.WriteLine("请输入订单号");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入客户名");
            string client = Console.ReadLine();
            Console.WriteLine("请输入商品名");
            string name = Console.ReadLine();
            Order O = new Order(id, client, name);
            foreach (Order order in L)
            {
                if (order.Equals(O) == true)
                {
                    Console.WriteLine("订单重复！");
                    return;
                }

            }
            L.Add(O);
        }

        public void Erase()
        {
            bool flag = false;
            Console.WriteLine("请输入订单号");
            int k = int.Parse(Console.ReadLine());
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
                Console.WriteLine("删除失败！");
                Console.WriteLine();
            }
        }

        public void Find()
        {
            bool flag = false;
            Console.WriteLine("请输入订单号");
            int k = int.Parse(Console.ReadLine());
            var m = from n in L where k == n.id select n;
            foreach(var n in m)
            {
                Console.WriteLine(n);
                flag = true;
            }
      /*      foreach (Order order in L)
            {
                if (order.id == k)
                {
                    Console.WriteLine(order);
                    flag = true;
                    break;
                }

            }*/
            if (flag == false)
            {
                Console.WriteLine("查找失败！");
                Console.WriteLine();
            }
        }

        public void Modify()
        {
            bool flag = false;
            Console.WriteLine("请输入要修改的订单号");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入修改后的客户名");
            string client = Console.ReadLine();
            Console.WriteLine("请输入修改后的商品名");
            string name = Console.ReadLine();
            Order O = new Order(k, client, name);
            foreach (Order order in L)
            {
                if (order.id == k)
                {
                    order.client = client;
                    order.name = name;
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("修改失败！");
                Console.WriteLine();
            }

        }

        public void Show()
        {
            L.Sort();
            foreach (Order order in L) Console.WriteLine(order);
            Console.WriteLine();
        }


        public void Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            String xmlFileName = "s.xml";
            FileStream fs = new FileStream(xmlFileName, FileMode.Create);
            xmlser.Serialize(fs, L);
            fs.Close();
        }


        public void Import()
        {
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                Order[] OrderListFromXML = (Order[])xmlSerializer.Deserialize(fs);
                Array.ForEach(OrderListFromXML, p => Console.WriteLine(p));
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OrderServices O = new OrderServices();
            while (true)
            {
                Console.WriteLine("输入1添加订单");
                Console.WriteLine("输入2删除订单");
                Console.WriteLine("输入3查找订单");
                Console.WriteLine("输入4修改订单");
                Console.WriteLine("输入5显示排序后的所有订单");
                Console.WriteLine("输入6序列化");
                Console.WriteLine("输入4反序列化");
                int k = int.Parse(Console.ReadLine());
                if (k == 1)
                    O.Add();
                else if (k == 2)
                    O.Erase();
                else if (k == 3)
                    O.Find();
                else if (k == 4)
                    O.Modify();
                else if (k == 5)
                    O.Show();
                else if (k == 6)
                    O.Export();
                else
                    O.Import();
            }
        }

    }
}
