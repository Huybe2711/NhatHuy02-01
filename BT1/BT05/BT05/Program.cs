using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int dongia;
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobaihat, int dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobaihat = sobaihat;
            this.dongia = dongia;

        }
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value;}
            get { return tuacd; }
        }
        public string Casi
        {
            set { this.casi = value; }
            get { return casi; }
        } 
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }

        }
        public int DonGia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
    }
}
