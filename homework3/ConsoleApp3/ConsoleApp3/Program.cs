using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class CellPhone
    {
        public abstract void Print();
    }

    public class HuaWei: CellPhone
    {
        public override void Print()
        {
            Console.WriteLine("生产了一台华为手机！");
        }
    }

    public class Iphone: CellPhone
    {
        public override void Print()
        {
            Console.WriteLine("生产了一台苹果手机！");
        }
    }

    public class XiaoMi: CellPhone
    {
        public override void Print()
        {
            Console.WriteLine("生产了一台小米手机!");
        }
    }

    public class PhoneFactory
    {
        private CellPhone phone = null;
        public CellPhone CreatePhone(string brand)
        {
            switch (brand)
            {
                case "HuaWei":
                    phone = new HuaWei();
                    break;
                case "Iphone":
                    phone = new Iphone();
                    break;
                case "XiaoMi":
                    phone = new XiaoMi();
                    break;
                default:
                    break;
            }
            return phone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneFactory factory = new PhoneFactory();
            CellPhone phone1 = factory.CreatePhone("HuaWei");
            CellPhone phone2 = factory.CreatePhone("Iphone");
            CellPhone phone3 = factory.CreatePhone("XiaoMi");
            phone1.Print();
            phone2.Print();
            phone3.Print();
        }
    }
}
