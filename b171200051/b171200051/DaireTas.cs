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
    public partial class DaireTas : Form
    {
        public ListBox lbDaire;
        
        public DaireTas(object secim)
        {
            InitializeComponent();
            daiAD.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            daiSOY.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            daiTEL.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            daiMETRE.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            daiSalon.Text= secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            daiOda.Text= secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            daiBalkon.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];
            daiUcret.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            daireCom.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[8];
            banyoCom.Text= secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[9];
            daireEkle.Text = "DEĞİŞTİR";
        }
        public DaireTas()
        {
            InitializeComponent();
        }

        private void daireEkle_Click(object sender, EventArgs e)
        {
            Daire daire = new Daire();
            void DaireAtama()
            {
                
                daire.Ad = daireAD.Text;
                daire.Soyad = daireSOY.Text;
                daire.telNo = daiTEL.Text;
                daire.MetreKare = daiMETRE.Text;
                daire.SalonSayisi = daiSalon.Text;
                daire.OdaSayisi = daiOda.Text;
                daire.BalkonSayisi = daiBalkon.Text;
                daire.Ucret = daiUcret.Text;

                if (daireCom.SelectedIndex == 1)
                    daire.Durum = daireCom.Text;
                else daire.Durum = daireCom.Text;

                if (banyoCom.SelectedIndex == 1)
                    daire.Banyo = banyoCom.Text;
                else daire.Banyo = banyoCom.Text;
            }
            if (daireEkle.Text == "EKLE")
                DaireAtama();
            else
            {
                Daire.eSil(lbDaire);
                lbDaire.Items.Remove(lbDaire.SelectedItem);
                DaireAtama();
            }
        }


    }
    
}
