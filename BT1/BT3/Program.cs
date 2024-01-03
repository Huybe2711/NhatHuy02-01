Bật thông báo trên màn hình cho Gmail.
   OK  Không, cảm ơn
1 trong tổng số 258
(không có chủ đề)
Hộp thư đến

K PĂ Y SAN HY C23A_TH1 <sanhysky@gmail.com>
Tệp đính kèm
08:12(0 phút trước)
đến tôi


 2 tệp đính kèm
  • Gmail đã quét
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Phanso
    {
        private int tuso;
        private int mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void settuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int gettuso()
        {
            return tuso;
        }
        public void setmauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getmauso()
        {
            return mauso;
        }
        public void Toigian()
        {
            int uscln = TimUSCLN(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public Phanso cong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso tru(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso nhan(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso chia(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
