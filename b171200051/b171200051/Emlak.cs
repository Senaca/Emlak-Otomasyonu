using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    abstract class Emlak
    {
        protected string ad;
        protected string soyad;
        protected string no;
        protected string durum;
        protected string ucret;
        protected string metrekare;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string telNo
        {
            get { return no; }
            set { no = value; }
        }
        public string Ucret
        {
            get { return ucret; }
            set { ucret = value; }
        }
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public string MetreKare
        {
            get { return metrekare; }
            set { metrekare = value; }
        }
      

        public static List<Arsa> arsaL = new List<Arsa>();
        
        
       

       protected static string metre_kare;
       protected static string salon_;
       protected static string oda_;
       protected static string balkon_;
       protected static string banyo_;
       protected static string katSay_;
        protected static string daireSay_;
       protected static string ad_;
       protected static string soyad_;
       protected static string tel_no;
       protected static string ucret_;
       protected static string durum_;

        
    }
}
