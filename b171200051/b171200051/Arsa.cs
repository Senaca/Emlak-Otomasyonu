using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    class Arsa:Emlak
    {
        public static void ArsaOlustur(ListBox liste)
        {
            ArsaTas arsaOlustur = new ArsaTas();
            arsaOlustur.lbArsa = liste;
            arsaOlustur.Show();
        }
        public static void eSil(ListBox liste)
        {

            ad_  = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            soyad_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            tel_no = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            metre_kare = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];           
            ucret_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            durum_ = liste.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            Emlak.arsaL.RemoveAll(
              arsa => arsa.Ad == ad_ && arsa.Soyad == soyad_ && arsa.telNo == tel_no  && arsa.MetreKare == metre_kare && arsa.Ucret == ucret_ && arsa.Durum == durum_);
            liste.Items.RemoveAt(liste.SelectedIndex);
        }
        public static void eDegistir(ListBox liste)
        {
            ArsaTas degistir = new ArsaTas(liste.SelectedItem);
            degistir.lbArsa = liste;
            degistir.Show();

        }
    }
}
