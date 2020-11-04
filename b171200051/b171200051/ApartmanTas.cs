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
    public partial class ApartmanTas : Form
    {
        public ListBox lbAprt;
        public ApartmanTas(object secim)
        {
            InitializeComponent();
            aprtAD.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[0];
            aprtSOY.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[1];
            aprtTEL.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[2];
            aprtMETRE.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[3];
            aprtSalon.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[4];
            aprtDaire.Text= secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[5];
            aprtOda.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[6];
            aprtBalkon.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[7];
            aprtUcret.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[9];
            aprtCom.Text = secim.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries)[10];            
            aprtEkle.Text = "DEĞİŞTİR";
        }
        public ApartmanTas()
        {
            InitializeComponent();
        }

        private void ApartmanTas_Load(object sender, EventArgs e)
        {

        }

        private void aprtEkle_Click(object sender, EventArgs e)
        {
            void ApartmanAtama()
            {
                Apartman apartman = new Apartman();
                apartman.Ad = aprtAD.Text;
                apartman.Soyad = aprtSOY.Text;
                apartman.telNo = aprtTEL.Text;
                apartman.MetreKare = aprtMETRE.Text;
                apartman.SalonSayisi = aprtSalon.Text;
                apartman.TopDaireS = aprtDaire.Text;
                apartman.OdaSayisi = aprtOda.Text;
                apartman.BalkonSayisi = aprtBalkon.Text;
                apartman.Ucret = aprtUcret.Text;

                if (aprtCom.SelectedIndex == 1)
                    apartman.Durum = aprtCom.Text;
                else apartman.Durum = aprtCom.Text;

                if (aprtEkle.Text == "EKLE")
                    ApartmanAtama();
                else
                {
                    Apartman.eSil(lbAprt);
                    lbAprt.Items.Remove(lbAprt.SelectedItem);
                    ApartmanAtama();
                }

            }
        }
    }
}
