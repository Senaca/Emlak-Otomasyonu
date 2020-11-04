using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    class Daire:Yapı
    {
        public static List<Daire> daireL = new List<Daire>();
        private string banyo;
        public string Banyo
        {
            get { return banyo; }
            set { banyo = value; }
        }

        public static void DaireOlustur(ListBox liste)
        {
            DaireTas daireOlustur = new DaireTas();
            daireOlustur.lbDaire = liste;
            daireOlustur.Show();
        }
        
        public static new void eSil(ListBox liste)
        {

            ad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            soyad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            tel_no = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            metre_kare = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            salon_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            oda_= liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            balkon_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];
            ucret_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            durum_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[8];
            banyo_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[9];

            Daire.daireL.RemoveAll(
              dai => dai.Ad == ad_ && dai.Soyad == soyad_ && dai.telNo == tel_no &&  dai.Durum == durum_ && dai.MetreKare == metre_kare && dai.SalonSayisi==salon_&& dai.OdaSayisi==oda_&& dai.BalkonSayisi==balkon_&& dai.Ucret == ucret_ && dai.Banyo==banyo_);
            liste.Items.RemoveAt(liste.SelectedIndex);
        }
        public static void eDegistir(ListBox liste)
        {
            DaireTas degistir = new DaireTas(liste.SelectedItem);
            degistir.lbDaire = liste;
            degistir.Show();

        }

    }
}
