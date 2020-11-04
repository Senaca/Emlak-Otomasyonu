using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    class Konut:Yapı
    {
        public static List<Konut> konutL = new List<Konut>();
        private string topKatS;
        public string TopKatS
        {
            get { return topKatS; }
            set { topKatS = value; }
        }

        public static void KonutOlustur(ListBox liste)
        {
            KonutTas kntOlustur = new KonutTas();
            kntOlustur.lbKonut = liste;
            kntOlustur.Show();
        }
        public static void eSil(ListBox liste)
        {

            ad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            soyad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            tel_no = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            metre_kare = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            katSay_= liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            salon_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            oda_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];         
            ucret_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            durum_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[8];
            

            Konut.konutL.RemoveAll(
              knt => knt.Ad == ad_ && knt.Soyad == soyad_ && knt.telNo == tel_no && knt.Durum == durum_ && knt.MetreKare == metre_kare && knt.TopKatS==katSay_ && knt.SalonSayisi==salon_ && knt.OdaSayisi==oda_ && knt.Ucret == ucret_);
            liste.Items.RemoveAt(liste.SelectedIndex);
        }
        public static void eDegistir(ListBox liste)
        {
            KonutTas degistir = new KonutTas(liste.SelectedItem);
            degistir.lbKonut = liste;
            degistir.Show();

        }
    }
}
