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
    public partial class Ekle : Form
    {
        public ListBox lbArsa;
        public ListBox lbDaire;
        public ListBox lbAprt;
        public ListBox lbKonut;
       

        public Ekle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Arsa.ArsaOlustur(LBoxArsa);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Apartman.eSil(LBoxAprt);
        }
        private void arsaDegistirBtn_Click(object sender, EventArgs e)
        {
            Arsa.eDegistir(LBoxArsa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arsa.eSil(LBoxArsa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Daire.DaireOlustur(LBoxDaire);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Daire.eDegistir(LBoxDaire);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Daire.eSil(LBoxDaire);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Apartman.AprtOlustur(LBoxAprt);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Apartman.eDegistir(LBoxAprt);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Konut.KonutOlustur(LBoxKnt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Konut.eDegistir(LBoxKnt);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Konut.eSil(LBoxKnt);
        }
        private void Ekle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Arsa.arsaL.Count; i++)
            {
                LBoxArsa.Items.Add(Arsa.arsaL[i].Ad + "  " + Arsa.arsaL[i].Soyad + "  " + Arsa.arsaL[i].telNo
                 + "  " + Arsa.arsaL[i].MetreKare + "  " + Arsa.arsaL[i].Ucret + "  "+ Arsa.arsaL[i].Durum);


            }
            for (int i = 0; i < Daire.daireL.Count; i++)
            {
                LBoxDaire.Items.Add(Daire.daireL[i].Ad + "  " + Daire.daireL[i].Soyad + "  " + Daire.daireL[i].telNo + "  " +
                Daire.daireL[i].MetreKare + "  " + Daire.daireL[i].SalonSayisi + "  " + Daire.daireL[i].OdaSayisi + "  " +
                Daire.daireL[i].BalkonSayisi + "  " + Daire.daireL[i].Ucret + "  " + Daire.daireL[i].Durum + "  " + Daire.daireL[i].Banyo);

            }

            for (int i = 0; i < Apartman.aprtL.Count; i++)
            {
                LBoxAprt.Items.Add(Apartman.aprtL[i].Ad + "  " + Apartman.aprtL[i].Soyad + "  " + Apartman.aprtL[i].telNo + "  " +
                Apartman.aprtL[i].MetreKare + "  " + Apartman.aprtL[i].SalonSayisi + "  " + Apartman.aprtL[i].TopDaireS + "  " + Apartman.aprtL[i].OdaSayisi
                + "  " + Apartman.aprtL[i].BalkonSayisi + "  " + Apartman.aprtL[i].Ucret + "  " + Apartman.aprtL[i].Durum);
            }
            for (int i = 0; i < Konut.konutL.Count; i++)
            {
                LBoxKnt.Items.Add(Konut.konutL[i].Ad + "  " + Konut.konutL[i].Soyad + "  " + Konut.konutL[i].telNo
                 + "  " + Konut.konutL[i].MetreKare + "  " + Konut.konutL[i].TopKatS + "  " + Konut.konutL[i].SalonSayisi
                + Konut.konutL[i].OdaSayisi + "  " + Konut.konutL[i].Ucret + "  " + Konut.konutL[i].Durum);
            }

        }

        
    }
}
