using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length * width;
        }
        public double findPerimeter()
        {
            return (length + width) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Rectangle r1;
            Rectangle r2;
            r1 = new Rectangle();

            Console.Write("Cho biết chiều dài:");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Cho biết chiều rộng:");
            double width = double.Parse(Console.ReadLine());

            r2 = new Rectangle(length, width);
            Console.WriteLine("----------------------Thông tin hình chữ nhật r1-----------------------");
            Console.WriteLine("\tChiều dài: {0}\t\tChiều rộng: {1}\n\tDiện tích: {2}\t\tChu vi: {3}", r1.getLength(), r1.getWidth(), r1.findArea(), r1.findPerimeter());

            Console.WriteLine("----------------------Thông tin hình chữ nhật r2-----------------------");
            Console.WriteLine("\tChiều dài: {0}\t\tChiều rộng: {1}\n\tDiện tích: {2}\t\tChu vi: {3}", r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPerimeter());

            Console.ReadLine();
        }
    }
}