using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    class Apartman:Yapı
    {
        public static List<Apartman> aprtL = new List<Apartman>();
        private string topDaireS;
        public string TopDaireS
        {
            get { return topDaireS; }
            set { topDaireS = value; }
        }

        public static void AprtOlustur(ListBox liste)
        {
            ApartmanTas aprtOlustur = new ApartmanTas();
            aprtOlustur.lbAprt = liste;
            aprtOlustur.Show();
        }
        public static void eSil(ListBox liste)
        {

            ad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            soyad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            tel_no = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            metre_kare = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            salon_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            daireSay_= liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            oda_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];
            balkon_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            ucret_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[8];
            durum_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[9];
            

            Apartman.aprtL.RemoveAll(
              aprt => aprt.Ad == ad_ && aprt.Soyad == soyad_ && aprt.telNo == tel_no && aprt.Durum == durum_ && aprt.MetreKare == metre_kare && aprt.SalonSayisi==salon_&&aprt.TopDaireS==daireSay_&&aprt.OdaSayisi==oda_&& aprt.BalkonSayisi==balkon_&& aprt.Ucret == ucret_);
            liste.Items.RemoveAt(liste.SelectedIndex);
        }
        public static void eDegistir(ListBox liste)
        {
            ApartmanTas degistir = new ApartmanTas(liste.SelectedItem);
            degistir.lbAprt = liste;
            degistir.Show();

        }
    }
}
