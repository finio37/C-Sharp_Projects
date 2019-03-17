using System;
//biblioteka obslugujaca liczby zespolone
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bs_project_4_liczby_zespolone
{
    public partial class bs_cala_formatka : Form
    {

        //utworzenie listy
        List<bs_liczba_zespolona> bs_lista = new List<bs_liczba_zespolona>(0);
        //trzyzmienne graficzne dla trzech rysownic
        public static Graphics bs_Rysownica;
        public static Graphics bs_dolna_Rysownica;
        public static Graphics bs_Rysownica_wynik;
        public bs_cala_formatka()
        {
            InitializeComponent();
            //inicjalizacja wszystkich trzech rysownic
            bs_Rysownica = bs_plotno_dla_Z1.CreateGraphics();
            bs_dolna_Rysownica = bs_plotno_dla_Z2.CreateGraphics();
            bs_Rysownica_wynik = bs_Z_wynik.CreateGraphics();
        }
        //implementacja klasy liczby zepsolonej
        public class bs_liczba_zespolona
        {
            //publiczne zmienne dostepne w kazdej metodzie klasy
            public double bs_x, bs_y;
            public Color bs_kolor_Z1;
            public int bs_grubosc;
            public int bs_szerokosc_rysownicy = 320;
            public int bs_wysokosc_rysownicy = 320;
            public int bs_pudelko1, bs_pudelko2;

            public int bs_szerokosc_dolnej_rysownicy = 330;
            // public int bs_wysokosc_dolnej_rysownicy = 110;
            public bs_liczba_zespolona(double x, double y, int grubosc)
            {
                this.bs_x = x;
                this.bs_y = y;
                this.bs_grubosc = grubosc;

            }

            //moteda rysujaca osie na lewej rysownicy
            public void narysuj_osie()
            {
                Pen bs_olowek_x = new Pen(Color.Blue, 1);
                Pen bs_olowek_y = new Pen(Color.Blue, 1);

                SolidBrush bs_pedzel_podzialki = new SolidBrush(Color.Black);
                Point pk1 = new Point(0, bs_wysokosc_rysownicy / 2);
                Point pk2 = new Point(bs_szerokosc_rysownicy, bs_wysokosc_rysownicy / 2);

                Point pk_y1 = new Point(bs_szerokosc_rysownicy / 2, 0);
                Point pk_y2 = new Point(bs_szerokosc_rysownicy / 2, bs_wysokosc_rysownicy);
                bs_Rysownica.DrawLine(bs_olowek_x, pk1, pk2);
                bs_Rysownica.DrawLine(bs_olowek_y, pk_y1, pk_y2);
                int bs_polowa_osi_x = bs_szerokosc_rysownicy / 2;
                int bs_polowa_osi_y = bs_wysokosc_rysownicy / 2;

                int bs_i = 0;
                int bs_i_y = 0;


                //compilator musi myslec, ze 1 pixel, to 20 pixeli
                //dlatego musimy dla osi zrobic przedzialke co 20 pixeli
                //robimy to przy pomocy dwuch petli while
                while (bs_i < bs_szerokosc_rysownicy)
                {
                    bs_Rysownica.FillEllipse(bs_pedzel_podzialki, bs_i, bs_polowa_osi_y, 3, 3);
                    bs_i += 20;
                }
                while (bs_i_y < bs_wysokosc_rysownicy)
                {
                    bs_Rysownica.FillEllipse(bs_pedzel_podzialki, bs_polowa_osi_x, bs_i_y, 3, 3);
                    bs_i_y += 20;
                }
            }
            public void narysuj_Z1()
            {



                //to sa dwie stale, dzeki ktorym wartosc x,y bedzie "skakac co 20 pixeli"
                //czy zgodnie z systemem naszej podzialki
                const double stala_dla_x = 20;
                const double stala_dla_y = 20;
                SolidBrush bs_pedzel = new SolidBrush(Color.Red);
                //wielkosc prostokata, na ktory zbudowana zostanie elipsa
                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                //dwa algorytmy, ktore wykonuja sie gdy wpisujemy liczby z dozwolonego zakresu 
                //od x=-8 do x=7 oraz od y=-8 do y=8
                //algorytm sluzy do ustawiania punktu zgodnie z systemem podziałki co 20 pixeli
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;


                bs_zero_y = bs_zero_y - (int)bs_y;


                //rysujemy podzialke
                bs_Rysownica.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);


            }
            //metoda, ktorza wykorzystujemy przy wyrazenia modulu pierwrzej liczby zespolonej
            //bez tej metody modul wygladalby niechlujnie
            public void narysuj_koniec_dlugosci()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;



                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            //metoda rysujaca prawa os
            public void narysuj_boczna_os()
            {
                Pen bs_olowek_x = new Pen(Color.Blue, 1);
                Pen bs_olowek_y = new Pen(Color.Blue, 1);
                SolidBrush bs_pedzel_podzialki = new SolidBrush(Color.Black);


                Point pk1 = new Point(0, bs_wysokosc_rysownicy / 2);
                Point pk2 = new Point(bs_szerokosc_dolnej_rysownicy, bs_wysokosc_rysownicy / 2);

                Point pk_y1 = new Point(bs_szerokosc_rysownicy / 2, 0);
                Point pk_y2 = new Point(bs_szerokosc_rysownicy / 2, bs_wysokosc_rysownicy);
                bs_dolna_Rysownica.DrawLine(bs_olowek_x, pk1, pk2);
                bs_dolna_Rysownica.DrawLine(bs_olowek_y, pk_y1, pk_y2);
                int bs_polowa_osi_x = bs_szerokosc_rysownicy / 2;
                int bs_polowa_osi_y = bs_wysokosc_rysownicy / 2;
                int bs_i = 0;
                int bs_i_y = 0;

                while (bs_i < bs_szerokosc_rysownicy)
                {
                    bs_dolna_Rysownica.FillEllipse(bs_pedzel_podzialki, bs_i, bs_polowa_osi_y, 3, 3);
                    bs_i += 20;
                }
                while (bs_i_y < bs_wysokosc_rysownicy)
                {
                    bs_dolna_Rysownica.FillEllipse(bs_pedzel_podzialki, bs_polowa_osi_x, bs_i_y, 3, 3);
                    bs_i_y += 20;
                }
            }
            //metoda rysujaca druga liczbe zespolona
            public void narysuj_Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;


                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;



                bs_dolna_Rysownica.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);
                //bs_Rysownica.FillEllipse(bs_pedzel,);
            }

            //metoda rysujaca sume liczb zepsolonych
            //rysowanie odbywa sie na trzeciej rysownicy
            public void narysuj_sume_Z1Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            //trzecia rysownica - odejmowanie liczb zespolonych
            public void narysuj_odejmowanie_Z1Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;


                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            //trzecia rysownica - mnozenie liczb zespolonych
            public void narysuj_mnozenie_Z1Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void narysuj_dzielenie_Z1Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void narysuj_odwrotnosc_Z1()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void narysuj_odwrotnosc_Z2()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void narysuj_czesc_rzeczywista_Z1()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;




                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void narysuj_czesc_urojona_Z1()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                SolidBrush bs_pedzel = new SolidBrush(Color.Red);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;


                bs_Rysownica_wynik.FillEllipse(bs_pedzel, bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);

            }
            public void dlugosc_Z1()
            {
                const double stala_dla_x = 20;
                const double stala_dla_y = 20;
                Pen bs_linia = new Pen(Color.Black);

                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                int bs_przesuniecie_y = (bs_wysokosc_rysownicy / 2);

                int bs_zero_y;
                bs_zero_y = bs_wysokosc_rysownicy / 2;
                bs_zero_y = bs_zero_y - (int)bs_y;

                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }
                Point poczatek_dlugosci = new Point(bs_przesuniecie_x, bs_przesuniecie_y);
                Point koniec_dlugosci = new Point((int)bs_x + bs_przesuniecie_x, bs_zero_y);

                bs_Rysownica_wynik.DrawLine(bs_linia, poczatek_dlugosci, koniec_dlugosci);
            }
            public void dlugosc_Z2()
            {
                const double stala_dla_x = 20;
                const double stala_dla_y = 20;
                Pen bs_linia = new Pen(Color.Black);

                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                int bs_przesuniecie_y = (bs_wysokosc_rysownicy / 2);

                int bs_zero_y;
                bs_zero_y = bs_wysokosc_rysownicy / 2;
                bs_zero_y = bs_zero_y - (int)bs_y;

                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }
                Point poczatek_dlugosci = new Point(bs_przesuniecie_x, bs_przesuniecie_y);
                Point koniec_dlugosci = new Point((int)bs_x + bs_przesuniecie_x, bs_zero_y);

                bs_Rysownica_wynik.DrawLine(bs_linia, poczatek_dlugosci, koniec_dlugosci);
            }
            public void bs_wykasuj()
            {

                const double stala_dla_x = 20;
                const double stala_dla_y = 20;

                Pen bs_linia = new Pen(Color.White);
                SolidBrush bs_pedzel = new SolidBrush(Color.White);

                int bs_width = 5;
                int bs_height = 5;

                int bs_zero_y;
                int bs_przesuniecie_x = (bs_szerokosc_rysownicy / 2);
                int bs_przesuniecie_y = (bs_wysokosc_rysownicy / 2);
                if (bs_x >= -8 && bs_x < 8)
                {
                    bs_x = bs_x * stala_dla_x;
                }


                if (bs_y >= -8 && bs_y < 9)
                {
                    bs_y = bs_y * stala_dla_y;
                }

                bs_zero_y = bs_wysokosc_rysownicy / 2;

                bs_zero_y = bs_zero_y - (int)bs_y;

                Point poczatek_dlugosci = new Point(bs_przesuniecie_x, bs_przesuniecie_y);
                Point koniec_dlugosci = new Point((int)bs_x + bs_przesuniecie_x, bs_zero_y);
                bs_Rysownica.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);
                bs_dolna_Rysownica.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);
                bs_Rysownica_wynik.FillEllipse(bs_pedzel, (int)(bs_x) + bs_przesuniecie_x - bs_width, bs_zero_y - bs_height, 2 * bs_width, 2 * bs_height);
                bs_Rysownica_wynik.DrawLine(bs_linia, poczatek_dlugosci, koniec_dlugosci);


            }

            public void narysuj_dolne_osie3()
            {
                Pen bs_olowek_x = new Pen(Color.Blue, 1);
                Pen bs_olowek_y = new Pen(Color.Blue, 1);

                SolidBrush bs_pedzel_podzialki = new SolidBrush(Color.Blue);


                Point pk1 = new Point(0, bs_wysokosc_rysownicy / 2);
                Point pk2 = new Point(bs_szerokosc_dolnej_rysownicy, bs_wysokosc_rysownicy / 2);

                Point pk_y1 = new Point(bs_szerokosc_rysownicy / 2, 0);
                Point pk_y2 = new Point(bs_szerokosc_rysownicy / 2, bs_wysokosc_rysownicy);
                bs_Rysownica_wynik.DrawLine(bs_olowek_x, pk1, pk2);
                bs_Rysownica_wynik.DrawLine(bs_olowek_y, pk_y1, pk_y2);
                int bs_polowa_osi_x = bs_szerokosc_rysownicy / 2;
                int bs_polowa_osi_y = bs_wysokosc_rysownicy / 2;
                int bs_i = 0;
                int bs_i_y = 0;

                while (bs_i < bs_szerokosc_rysownicy)
                {
                    bs_Rysownica_wynik.FillEllipse(bs_pedzel_podzialki, bs_i, bs_polowa_osi_y, 3, 3);
                    bs_i += 20;
                }
                while (bs_i_y < bs_wysokosc_rysownicy)
                {
                    bs_Rysownica_wynik.FillEllipse(bs_pedzel_podzialki, bs_polowa_osi_x, bs_i_y, 3, 3);
                    bs_i_y += 20;
                }
            }
        }

        private void bs_rysuj_Z1_Click(object sender, EventArgs e)
        {
            double x, y;
            //zabezpieczenie przed stringami
            try
            {
                x = Convert.ToDouble(bs_re.Text);
                y = Convert.ToDouble(bs_im.Text);
                //zabezpieczenie przed liczbami z poza dozwolonego zakresu
                if ((x < -8) || (x > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                if ((y < -8) || (y > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                //stworzenie instancji liczby zespolonej
                Complex z1 = new Complex(x, y);

                int bs_grubosc = 15;
                //odpalenie klasy i jej odpowiednich metod
                bs_lista.Add(new bs_liczba_zespolona(x, y, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_Z1();
                bs_lista[bs_lista.Count - 1].narysuj_osie();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie moga byc puste! Litery zabronione!");
            }
        }

        private void bs_rysuj_Z2_Click(object sender, EventArgs e)
        {
            double x2, y2;
            try
            {
                x2 = Convert.ToDouble(bs2_re.Text);
                y2 = Convert.ToDouble(bs2_im.Text);
                if ((x2 < -8) || (x2 > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                if ((y2 < -8) || (y2 > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                Complex z2 = new Complex(x2, y2);
                int bs_grubosc = 15;
                bs_lista.Add(new bs_liczba_zespolona(x2, y2, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_Z2();
                bs_lista[bs_lista.Count - 1].narysuj_boczna_os();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z2, "Pola nie mogą być puste! Litery zabronione!");
            }
        }

        private void bs_dodajZ1Z2_Click(object sender, EventArgs e)
        {
            double bs_x1_suma, bs_y1_suma;
            double bs_x2_suma, bs_y2_suma;
            try
            {
                bs_x1_suma = Convert.ToDouble(bs_re.Text);
                bs_y1_suma = Convert.ToDouble(bs_im.Text);

                bs_x2_suma = Convert.ToDouble(bs2_re.Text);
                bs_y2_suma = Convert.ToDouble(bs2_im.Text);

                double x3, y3;
                int bs_grubosc = 5;
                Complex z_suma = new Complex(bs_x1_suma, bs_y1_suma);
                Complex z2_suma = new Complex(bs_x2_suma, bs_y2_suma);
                Complex bs_cala_suma = Complex.Add(z_suma, z2_suma);
                x3 = bs_cala_suma.Real;
                y3 = bs_cala_suma.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x3, y3, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_sume_Z1Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zabronione!");
                return;
            }
        }

        private void bs_odejmijZ1Z2_Click(object sender, EventArgs e)
        {
            double bs_x1_odejmowanie, bs_y1_odejmowanie;
            double bs_x2_odejmowanie, bs_y2_odejmowanie;
            double x4, y4;
            try
            {
                bs_x1_odejmowanie = Convert.ToDouble(bs_re.Text);
                bs_y1_odejmowanie = Convert.ToDouble(bs_im.Text);

                bs_x2_odejmowanie = Convert.ToDouble(bs2_re.Text);
                bs_y2_odejmowanie = Convert.ToDouble(bs2_im.Text);
                int bs_grubosc = 5;
                Complex z_odejmowanie = new Complex(bs_x1_odejmowanie, bs_y1_odejmowanie);
                Complex z2_odejmowanie = new Complex(bs_x2_odejmowanie, bs_y2_odejmowanie);
                Complex bs_wynik_odejmowania = Complex.Subtract(z_odejmowanie, z2_odejmowanie);
                x4 = bs_wynik_odejmowania.Real;
                y4 = bs_wynik_odejmowania.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x4, y4, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_odejmowanie_Z1Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zakazane!");
                return;
            }
        }

        private void bs_mnozenie_Click(object sender, EventArgs e)
        {
            double bs_x1_mnozenie, bs_y1_mnozenie;
            double bs_x2_mnozenie, bs_y2_mnozenie;
            double x5, y5;
            try
            {
                bs_x1_mnozenie = Convert.ToDouble(bs_re.Text);
                bs_y1_mnozenie = Convert.ToDouble(bs_im.Text);

                bs_x2_mnozenie = Convert.ToDouble(bs_re.Text);
                bs_y2_mnozenie = Convert.ToDouble(bs_im.Text);
                int bs_grubosc = 10;

                Complex z1_mnozenie = new Complex(bs_x1_mnozenie, bs_y1_mnozenie);
                Complex z2_mnozenie = new Complex(bs_x2_mnozenie, bs_y2_mnozenie);
                Complex bs_wynik_mnozenia = Complex.Multiply(z1_mnozenie, z2_mnozenie);
                x5 = bs_wynik_mnozenia.Real;
                y5 = bs_wynik_mnozenia.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x5, y5, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_mnozenie_Z1Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zakazane!");
            }
        }

        private void bs_dzielenieZ1Z2_Click(object sender, EventArgs e)
        {
            double bs_x1_dzielenie, bs_y1_dzielenie;
            double bs_x2_dzielenie, bs_y2_dzielenie;
            double x6, y6;
            try
            {
                bs_x1_dzielenie = Convert.ToDouble(bs_re.Text);
                bs_y1_dzielenie = Convert.ToDouble(bs_im.Text);

                bs_x2_dzielenie = Convert.ToDouble(bs2_re.Text);
                bs_y2_dzielenie = Convert.ToDouble(bs2_im.Text);
                int bs_grubosc = 10;
                Complex z1_dzielenie = new Complex(bs_x1_dzielenie, bs_y1_dzielenie);
                Complex z2_dzielenie = new Complex(bs_x2_dzielenie, bs_y2_dzielenie);
                Complex bs_wynik_dzielenia = Complex.Divide(z1_dzielenie, z2_dzielenie);
                x6 = bs_wynik_dzielenia.Real;
                y6 = bs_wynik_dzielenia.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x6, y6, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_dzielenie_Z1Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zakazane!");
                return;
            }
        }

        private void bs_odwrotnoscZ1_Click(object sender, EventArgs e)
        {
            double bs_x1_odwrocenie, bs_y1_odwrocenie;
            double x7, y7;
            try
            {
                bs_x1_odwrocenie = Convert.ToDouble(bs_re.Text);
                bs_y1_odwrocenie = Convert.ToDouble(bs_im.Text);
                if ((bs_x1_odwrocenie < -8) || (bs_x1_odwrocenie > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                if ((bs_y1_odwrocenie < -8) || (bs_y1_odwrocenie > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                int bs_grubosc = 10;
                Complex z1_odwrocenie = new Complex(bs_x1_odwrocenie, bs_y1_odwrocenie);
                Complex bs_wynik_odwrocenia = Complex.Negate(z1_odwrocenie);
                x7 = bs_wynik_odwrocenia.Real;
                y7 = bs_wynik_odwrocenia.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x7, y7, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_odwrotnosc_Z1();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zakazane!");
                return;
            }
        }

        private void bs_odwrotnoscZ2_Click(object sender, EventArgs e)
        {
            double bs_x1_odwrocenie, bs_y1_odwrocenie;
            double x8, y8;
            try
            {
                bs_x1_odwrocenie = Convert.ToDouble(bs2_re.Text);
                bs_y1_odwrocenie = Convert.ToDouble(bs2_im.Text);
                if ((bs_x1_odwrocenie < -8) || (bs_x1_odwrocenie > 8)) { bs_error.SetError(bs_rysuj_Z2, "Liczby poza zakresem"); return; }
                if ((bs_y1_odwrocenie < -8) || (bs_y1_odwrocenie > 8)) { bs_error.SetError(bs_rysuj_Z2, "Liczby poza zakresem"); return; }
                int bs_grubosc = 10;
                Complex z2_odwrocenie = new Complex(bs_x1_odwrocenie, bs_y1_odwrocenie);
                Complex bs_wynik_odwrocenia_z2 = Complex.Negate(z2_odwrocenie);
                x8 = bs_wynik_odwrocenia_z2.Real;
                y8 = bs_wynik_odwrocenia_z2.Imaginary;

                bs_lista.Add(new bs_liczba_zespolona(x8, y8, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_odwrotnosc_Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z2, "Pola nie mogą być puste! Litery zakazane!");
                return;

            }
        }

        private void bs_wyczysc_wykresy_Click(object sender, EventArgs e)
        {
            for (int bs_i = 0; bs_i < bs_lista.Count; bs_i++)
            {
                bs_lista[bs_i].bs_wykasuj();
            }
           /* bs_Z_wynik.Dispose();
            bs_plotno_dla_Z1.Dispose();
            bs_plotno_dla_Z2.Dispose();
            bs_Z_wynik.BackColor = Color.White;
            bs_plotno_dla_Z1.BackColor = Color.White;
            bs_plotno_dla_Z2.BackColor = Color.White;*/
        }

        private void bs_re_z1_Click(object sender, EventArgs e)
        {
            double bs_x1_re, bs_y1_im;
            double x9;

            double y9 = 0;

            int bs_grubosc = 10;
            try
            {
                bs_x1_re = Convert.ToDouble(bs_re.Text);
                bs_y1_im = Convert.ToDouble(bs_im.Text);
                if ((bs_x1_re < -8) || (bs_x1_re > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                if ((bs_y1_im < -8) || (bs_y1_im > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                Complex bs_czesc_rzywista = new Complex(bs_x1_re, bs_y1_im);
                x9 = bs_czesc_rzywista.Real;

                bs_lista.Add(new bs_liczba_zespolona(x9, y9, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_czesc_rzeczywista_Z1();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zabronione!");
                return;
            }
        }

        private void bs_czesc_urojona_z1_Click(object sender, EventArgs e)
        {
            double bs_x1_re, bs_y1_im;
            double x10 = 0;
            double y10;
            int bs_grubosc = 10;
            try
            {
                bs_x1_re = Convert.ToDouble(bs_re.Text);
                bs_y1_im = Convert.ToDouble(bs_im.Text);
                if ((bs_x1_re < -8) || (bs_x1_re > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                if ((bs_y1_im < -8) || (bs_y1_im > 8)) { bs_error.SetError(bs_rysuj_Z1, "Liczba poza zakresem"); return; }
                Complex bs_czesc_urojona = new Complex(bs_x1_re, bs_y1_im);
                y10 = bs_czesc_urojona.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x10, y10, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_czesc_urojona_Z1();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_rysuj_Z1, "Pola nie mogą być puste! Litery zakazane!");
                return;
            }
        }

        private void bs_resetowanie_errorow_Click(object sender, EventArgs e)
        {
            bs_error.Dispose();
            
            bs_re.Text = "";
            bs_im.Text = "";
            bs2_re.Text = "";
            bs2_im.Text = "";
        }

        private void bs_modul_Z1_Click(object sender, EventArgs e)
        {
            double bs_x1_modul, bs_y1_modul;
            double x11, y11;
            int bs_grubosc = 10;
            try
            {
                bs_x1_modul = Convert.ToDouble(bs_re.Text);
                bs_y1_modul = Convert.ToDouble(bs_im.Text);
                Complex bs_z1_modul = new Complex(bs_x1_modul, bs_y1_modul);
                x11 = bs_z1_modul.Real;
                y11 = bs_z1_modul.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x11, y11, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_koniec_dlugosci();
                bs_lista[bs_lista.Count - 1].dlugosc_Z1();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_modul_Z1, "Pola tekstowe Z1 nie mogą być puste! Litery są zabronione!");
                return;
            }
        }

        private void bs_modul_Z2_Click(object sender, EventArgs e)
        {
            double bs_x1_modul, bs_y1_modul;
            double x11, y11;
            int bs_grubosc = 10;
            try
            {
                bs_x1_modul = Convert.ToDouble(bs2_re.Text);
                bs_y1_modul = Convert.ToDouble(bs2_im.Text);
                Complex bs_z1_modul = new Complex(bs_x1_modul, bs_y1_modul);
                x11 = bs_z1_modul.Real;
                y11 = bs_z1_modul.Imaginary;
                bs_lista.Add(new bs_liczba_zespolona(x11, y11, bs_grubosc));
                bs_lista[bs_lista.Count - 1].narysuj_dolne_osie3();
                bs_lista[bs_lista.Count - 1].narysuj_koniec_dlugosci();
                bs_lista[bs_lista.Count - 1].dlugosc_Z2();
            }
            catch (Exception k)
            {
                bs_error.SetError(bs_modul_Z1, "Pola tekstowe Z1 nie mogą być puste! Litery są zabronione!");
                return;
            }
        }

    }
}
