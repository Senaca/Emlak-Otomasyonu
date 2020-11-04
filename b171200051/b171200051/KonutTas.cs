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
    public partial class KonutTas : Form
    {
        public ListBox lbKonut;
        public KonutTas(object secim)
        {
            InitializeComponent();
            konutAD.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            konutSOY.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            konutTEL.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            konutMETRE.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            konutKatS.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            kntSalon.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            kntOda.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];            
            kntUcret.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            konutCom.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[8];
            konutEkle.Text = "DEĞİŞTİR";
        }
        public KonutTas()
        {
            InitializeComponent();
        }

        private void KonutTas_Load(object sender, EventArgs e)
        {

        }

        private void konutEkle_Click(object sender, EventArgs e)
        {
            void KonutAtama()
            {
                Konut konut = new Konut();
                konut.Ad = konutAD.Text;
                konut.Soyad = konutSOY.Text;
                konut.telNo = konutTEL.Text;
                konut.MetreKare = konutMETRE.Text;
                konut.TopKatS = konutKatS.Text;
                konut.SalonSayisi = kntSalon.Text;
                konut.OdaSayisi = kntOda.Text;
                konut.Ucret = kntUcret.Text;

                if (konutCom.SelectedIndex == 1)
                    konut.Durum = konutCom.Text;
                else konut.Durum = konutCom.Text;

                if (konutEkle.Text == "EKLE")
                    KonutAtama();
                else
                {
                    Konut.eSil(lbKonut);
                    lbKonut.Items.Remove(lbKonut.SelectedItem);
                    KonutAtama();
                }

            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
