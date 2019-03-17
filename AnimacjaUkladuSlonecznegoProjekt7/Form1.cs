using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animacja_ukladu_slonecznego
{
    public partial class PrzestrzenUkladuSlonecznego : Form
    {
        //zmienne katowe
        float bs_kat_obrotu_ziemi;
        float bs_kat_obrotu_ksiezyca;
        
        //zmienne przyrostu katow
        float bs_wielkosc_zmiany_obr_ziemi=0.05F;
        float bs_wielkosc_zmiany_obr_ksiez=0.05F;

        //stale
        //promien slonca
        const int bs_R_Slonca = 50;
        //promien ziemi
        const int bs_R_Ziemi = 25;
        //promien ksiezyca
        const int bs_R_Ksiez = 5;

        //deklaracja zmiennych torow cial niebieskich
        int bs_tor_ziemi;
        int bs_tor_ksiezyca;

        public PrzestrzenUkladuSlonecznego()
        {
            InitializeComponent();
            this.Left = 10;
            this.Top = 10;

            //ustawienie wysokosci i szerokosci screenu
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width*0.7F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height*0.7f);

            //ustawienie koloru tla
            this.BackColor = Color.RoyalBlue;

            //zablokowanie zmiany rozwiarow width i height
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);

            //wylaczenia minimalizacji i maksymalizacji okna
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            bs_tor_ziemi = this.Width / 5;
            bs_tor_ksiezyca = this.Width / 12;

        }

        private void PrzestrzenUkladuSlonecznego_Paint(object sender, PaintEventArgs e)
        {
            
            //narysowanie elipsy w kształcie okregu oraz wypelnienie jej czerwonym kolorem
            //nastepnie ustawienie obiektu okregu na srodku ekranu 
            //oraz ustawienie wielkosci okregu na szer i wys
            e.Graphics.FillEllipse(Brushes.Red, this.Width/2 - bs_R_Slonca,
                this.Height/2 - bs_R_Slonca,2*bs_R_Slonca,2*bs_R_Slonca);
            
            //wyznaczenie poczatkowego polozenia ziemi
            float x_ziemi = (float)(this.Width / 2 + bs_tor_ziemi*Math.Cos(bs_kat_obrotu_ziemi));
            float y_ziemi = (float)(this.Height/2 + bs_tor_ziemi*Math.Sin(bs_kat_obrotu_ziemi));

            e.Graphics.FillEllipse(Brushes.LimeGreen,x_ziemi-bs_R_Ziemi,y_ziemi-bs_R_Ziemi,
                2*bs_R_Ziemi,2*bs_R_Ziemi);

            //wyznaczenie poczatkowego polozenia ksiezyca
            float x_ksiezyca = (float)(x_ziemi + bs_tor_ksiezyca * Math.Cos(bs_kat_obrotu_ksiezyca));
            float y_ksiezyca = (float)(y_ziemi + bs_tor_ksiezyca*Math.Sin(bs_kat_obrotu_ksiezyca));

            e.Graphics.FillEllipse(Brushes.LightYellow,x_ksiezyca-bs_R_Ksiez,y_ksiezyca-bs_R_Ksiez,
                2*bs_R_Ksiez,2*bs_R_Ksiez);




        }

        private void bs_ZegarUkladuSlonecznego_Tick(object sender, EventArgs e)
        {
            this.bs_ZegarUkladuSlonecznego.Enabled = true;
            this.bs_kat_obrotu_ziemi = this.bs_kat_obrotu_ziemi + this.bs_wielkosc_zmiany_obr_ziemi;
            if (bs_kat_obrotu_ziemi >= 360F)
                 this.bs_kat_obrotu_ziemi = 0;
            
            this.bs_kat_obrotu_ksiezyca = this.bs_kat_obrotu_ksiezyca - this.bs_wielkosc_zmiany_obr_ksiez;
            if (bs_kat_obrotu_ksiezyca >= 360F)
            
                this.bs_kat_obrotu_ksiezyca = 0;
            
            this.Invalidate();
        }
    }
}
