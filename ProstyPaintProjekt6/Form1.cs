using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class bs_pulpit_paint : Form
    {
        //bsz_pioro, czyli narzedzie do rysowania
        Pen bs_pioro = new Pen(Color.Blue, 2);
        
        //zmienna, ktorej uzyjemy w megodzie drawline
        Point bs_Punkt = new Point();
        
        //zmienna referencyjna dla powierzchni graficznej
        Graphics bs_refRysownica;
        
        SolidBrush bs_pedzel = new SolidBrush(Color.Red);
        public bs_pulpit_paint()
        {
            InitializeComponent();
                       
            //ustawienie wymiarow formularza
            this.Left = 20;
            this.Top = 20;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width*0.8F);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Height*0.8F);
            
            //uniemozliwienie zmiany szerokosci i wysokosci
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);

            //wylaczenie maxymalizacji i minimalizacji
            this.MaximizeBox = false;
            this.MinimizeBox = false;

                       
            //ustalenie koloru tla dla rysownicy
            bs_rysownica.BackColor = Color.LightYellow;
            
            //ustalenie obramowanie dla rysownicy
            bs_rysownica.BorderStyle = BorderStyle.Fixed3D;

            //obiekt powierzchni graficznej w postaci bitmapy
            bs_rysownica.Image = new Bitmap(bs_rysownica.Width,bs_rysownica.Height);
            
            //zapisanie bitmapowej powierzchni bitmapowej do zmiennej referencyjnej
            bs_refRysownica = Graphics.FromImage(bs_rysownica.Image);
            

        }

        //funkcja obslugujaca suwak grubosc linii
        private void bs_suwak_grubosci_Scroll(object sender, EventArgs e)
        {
            //synchronizacja 
            bs_numeric_grubosci.Value = bs_suwak_grubosci.Value;
            bs_pioro.Width = bs_suwak_grubosci.Value;
            bs_wziernik.Invalidate();
            
        }

        private void bs_wziernik_Paint(object sender, PaintEventArgs e)
        {
            //narysowanie linii we wzierniku
            Point bs_pt1 = new Point(1,10);
            Point bs_pt2 = new Point(150,10);
            e.Graphics.DrawLine(bs_pioro,bs_pt1,bs_pt2);
        }

        //funkcja obslugujaca numeryczna zmiane grubosci linii
        private void bs_numeric_grubosci_ValueChanged(object sender, EventArgs e)
        {
            
            //synchronizacja
            bs_suwak_grubosci.Value = (int)bs_numeric_grubosci.Value;
            bs_pioro.Width = bs_suwak_grubosci.Value;
            bs_wziernik.Invalidate();
        }

        private void bs_rysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //rozpoznanie polorzenia kursora myszy przy kliknieciu lewym klawiszem myszy
            bs_wspolrzedna_x.Text = e.Location.X.ToString();
            bs_wspolrzedna_y.Text = e.Location.Y.ToString();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                bs_Punkt = e.Location;
        }

        private void bs_rysownica_MouseUp(object sender, MouseEventArgs e)
        {
            //rozpoznanie polorzenia kursowa myszy
            bs_wspolrzedna_x.Text = e.Location.X.ToString();
            bs_wspolrzedna_y.Text = e.Location.Y.ToString();
            
            //zmienne, ktore wykorzystamy do resowania figur
            int bs_lewy_naroznik_x, bs_lewy_naroznik_y;
            int bs_szer, bs_wys;
            
                      
            //jesli punkt poczatkowy jest wiekszy od kocowej lokalizacji, to
            if (bs_Punkt.X > e.Location.X)
            {
                //przypisanie ostatecznej lokalicacji z do zmiennej bs_lewy_naroznik_x
                bs_lewy_naroznik_x = e.Location.X;
            }
            else
            {
                //w przeciwnym razie przypisa punkt poczatkowy do lewego naroznika
                bs_lewy_naroznik_x = bs_Punkt.X;
            }
            //to samo co u gory, tylko dla y
            if (bs_Punkt.Y > e.Location.Y)
            {
                bs_lewy_naroznik_y = e.Location.Y;
            }
            else
            {
                bs_lewy_naroznik_y = bs_Punkt.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //jesli wybralismy olowek, to rysuje sie prosta linia
                if (bs_olowek.Checked)
                {
                    bs_refRysownica.DrawLine(bs_pioro,bs_Punkt,e.Location);
                    bs_rysownica.Invalidate();
                }
                //jesli wybralismy okrat, to rysuje sie okrag
                if (bs_okrag.Checked)
                {
                    bs_szer = Math.Abs(e.Location.X - bs_Punkt.X);
                    bs_wys = bs_szer;
                    bs_refRysownica.DrawEllipse(bs_pioro,new Rectangle(bs_lewy_naroznik_x,bs_lewy_naroznik_y,bs_szer,bs_wys));
                    bs_rysownica.Invalidate();
                }
                
                //jesli wybralismy prostokat, to rysuje sie prostokat
                if (bs_prostokat.Checked)
                {
                    bs_szer = Math.Abs(e.Location.X - bs_Punkt.X);
                    bs_wys = Math.Abs(e.Location.Y - bs_Punkt.Y);
                    bs_refRysownica.DrawRectangle(bs_pioro,new Rectangle(bs_lewy_naroznik_x,bs_lewy_naroznik_y,bs_szer,bs_wys));
                    bs_rysownica.Invalidate();
                }
                
            }


        }

        private void bs_rysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //rozpoznanie polozeniamszy
            bs_wspolrzedna_x.Text = e.Location.X.ToString();
            bs_wspolrzedna_y.Text = e.Location.Y.ToString();
        }

        //mozliwosc ustawienia koloru linii
        private void bs_color_linii_Click(object sender, EventArgs e)
        {
            //delkaracja zmiennej zarzadzania kolorami
            ColorDialog bs_okno_zkolorami = new ColorDialog();
            if (bs_okno_zkolorami.ShowDialog() == DialogResult.OK)
            {
                //zapisanie wyboru koloru
                bs_pioro.Color = bs_okno_zkolorami.Color;
                bs_wziernik.Invalidate();
            }
        }

        //mozliwosc zapisania rysunku na dysku
        private void bs_zapisz_rysunek_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennej zapisu
            SaveFileDialog bs_okno_zapisu = new SaveFileDialog();
            
            //wybor rodzaju rozszerzenia i zapisanie go w zmiennej
            bs_okno_zapisu.Filter = "bmp|*.bmp";
            if (bs_okno_zapisu.ShowDialog() == DialogResult.OK)
            {
                if (bs_okno_zapisu.FileName != "")
                {
                    //polecenie zapisania bitmapy
                    bs_rysownica.Image.Save(bs_okno_zapisu.FileName);
                }
            }
        }

       //mozliwosc otwarcia rysunku
        private void bs_otworz_rysunek_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennej do otwarcia pliku
            OpenFileDialog bs_otwieranie = new OpenFileDialog();
            if (bs_otwieranie.ShowDialog() == DialogResult.OK)
            {
                //zmienna string, w ktorej przechowywac bedziemy nazwe pliku
                string bs_nazwa_pliku = bs_otwieranie.FileName;
                Bitmap bs_bitmapa = new Bitmap(bs_nazwa_pliku);
                bs_refRysownica.DrawImage(bs_bitmapa,bs_rysownica.Left,bs_rysownica.Top);
                bs_rysownica.Refresh();
            }
        }

        

        //mozliwosc zmiany koloru tla rysownicy
        private void bs_kolor_tla_Click(object sender, EventArgs e)
        {
            ColorDialog bs_okno_kolorow = new ColorDialog();
            if (bs_okno_kolorow.ShowDialog() == DialogResult.OK)
            {
                bs_refRysownica.Clear(bs_okno_kolorow.Color);
                bs_rysownica.Invalidate();
            }
        }
        
        //mozliwosc wyboru rodzaju linii
        private System.Drawing.Drawing2D.DashStyle bs_stylLinii(int i)
        {
            switch (i)
            { 
                case 0:
                    return System.Drawing.Drawing2D.DashStyle.Dash;
                    
                case 1:
                    return System.Drawing.Drawing2D.DashStyle.DashDot;
                case 2:
                    return System.Drawing.Drawing2D.DashStyle.DashDotDot;
                case 3:
                    return System.Drawing.Drawing2D.DashStyle.Dot;
                case 4:
                    return System.Drawing.Drawing2D.DashStyle.Solid;
                default:
                    MessageBox.Show("Nie ma takiego stylu");
                    return System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        //w tej metodzie wykorzystujemy funkcję wyrzej
        private void bs_style_linii_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prypisanie do zmiennej z wlasciwoscia dashstyle naszego wyboru linii
            bs_pioro.DashStyle = bs_stylLinii(bs_style_linii.SelectedIndex);
            bs_wziernik.Invalidate();
        }
        
    }
}
