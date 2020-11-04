using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b171200051
{
    public partial class ArsaTas : Form
    {
        public ListBox lbArsa;
       // protected static Arsa arsa = new Arsa();
        public ArsaTas(object secim)
        {           
            InitializeComponent();
            arsaAD.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            arsaSOY.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            arsaTEL.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            arsaMETRE.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            arsaUcret.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            arsaDurum.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            arsaEkle.Text = "Değiştir";
        }
        public ArsaTas()
        {
            InitializeComponent();
        }

        private void arsaEkle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ArsaTas_Load(object sender, EventArgs e)
        {

        }

        private void arsaEkle_Click_1(object sender, EventArgs e)
        {
            //Arsa arsa = new Arsa();
           
            void ArsaAtama()
            {
                Arsa arsa = new Arsa();
                arsa.Ad = arsaAD.Text;
                arsa.Soyad = arsaSOY.Text;
                arsa.telNo = arsaTEL.Text;
                arsa.MetreKare = arsaMETRE.Text;
                arsa.Ucret = arsaUcret.Text;

                if (arsaDurum.SelectedIndex == 1)
                    arsa.Durum = arsaDurum.Text;
                else arsa.Durum = arsaDurum.Text;
                Emlak.arsaL.Add(arsa);
                lbArsa.Items.Add(
                    arsa.Ad + "  " + arsa.Soyad + "  " + arsa.telNo + "  " + arsa.MetreKare + "  " + arsa.Ucret + "  " + arsa.Durum);

            }
           
            if (arsaEkle.Text == "EKLE")
                ArsaAtama();
            else
            {
               Arsa.eSil(lbArsa);
               lbArsa.Items.Remove(lbArsa.SelectedItem);
                ArsaAtama();
            }
        }
    }
}
