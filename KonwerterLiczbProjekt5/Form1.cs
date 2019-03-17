using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace konwersja_liczb
{
    public partial class konwerter_liczb : Form
    {

        //deklaracje zmiennych
        int bs_liczba;
        
        //deklaracja zmiennej znakowej
        char bs_Cyfra;
        //inne zmienne oraz zmienna tablicowa
        int bs_i;
        int bs_n;
        int bs_L;
        char[] bs_tablica_cyfr = new char[50];
      
        public konwerter_liczb()
        {
            InitializeComponent();
            //przypisanie to pierwszych indexow comba wartosc 0
            lewa_lista.SelectedIndex = 0;
            prawa_lista.SelectedIndex = 0;
        }

        //resetowanie stanu programu
        private void btnResetuj_Click(object sender, EventArgs e)
        {
            lewa_lista.Enabled = true;
            prawa_lista.Enabled = true;
            wpisz_liczbe.Enabled = true;
            //po kliknieciu resetuj naszego przyciski i pole, znowu sa aktywne
            lewa_lista.SelectedIndex = 0;
            prawa_lista.SelectedIndex = 0;
            //wylaczenie errorProvidera
            errorProvider2.Dispose();
            errorProvider1.Dispose();
            //szczyszczenie wyniku
            wynik_po_konwersji.Text = "";
            wpisz_liczbe.Text = "";

        }
        

        private void koniec_programu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void konwertuj_Click(object sender, EventArgs e)
        {
            string bs_liczba_przed_konwersja, bs_liczba_po_konwersji;
            //deklaracja zmiennych, w ktorych przechowywane sa opcję combo
            int bs_lewa_podstawa, bs_prawa_podstawa;
            switch (lewa_lista.SelectedIndex)
            {
                case 0: bs_lewa_podstawa = 10; break;
                case 1: bs_lewa_podstawa = 8; break;
                case 2: bs_lewa_podstawa = 16; break;
                case 3: bs_lewa_podstawa = 2; break;
                default: bs_lewa_podstawa = 10; break;
            }
            switch (prawa_lista.SelectedIndex)
            {
                case 0: bs_prawa_podstawa = 10; break;
                case 1: bs_prawa_podstawa = 8; break;
                case 2: bs_prawa_podstawa = 16; break;
                case 3: bs_prawa_podstawa = 2; break;
                default: bs_prawa_podstawa = 10; break;
            }
            //jesli pole pozostawimy puste, wyswietli sie error
            if (string.IsNullOrEmpty(wpisz_liczbe.Text))
            {
                errorProvider1.SetError(wpisz_liczbe, "Nie wpisaleś liczby");
                return;
            }
            else
            {
                errorProvider1.Dispose();
            }
            //przypisanie zawartosc textboxa o nazwie "wpisz_liczbe" do zmiennej
            //bs_liczba_przed_konwersja
            bs_liczba_przed_konwersja = wpisz_liczbe.Text;
            //chwilowe wylaczenie pol
            lewa_lista.Enabled = false;
            prawa_lista.Enabled = false;
            wpisz_liczbe.Enabled = false;
            //usuniecie spracji korzystajac z metody trim
            bs_liczba_przed_konwersja = bs_liczba_przed_konwersja.Trim();
            if (CzyLiczbaJestZapisanaPoprawnie(bs_liczba_przed_konwersja,bs_lewa_podstawa))
            {
                //przypisanie ilosci znakow zmiennej liczba_przed_konwersja do zmiennej
                //bs_n
                bs_n = bs_liczba_przed_konwersja.Length;
                //inicjalizacja zmiennej bs_l
                bs_L = 0;
                //poczatek petli
                for (int bs_i = 0; bs_i < bs_n; bs_i++)
                { 
                    //przy kazdej iteracji, znak ze string jest przypisywany
                    //zmiennej bs_cyfra
                    bs_Cyfra = bs_liczba_przed_konwersja[bs_i];
                    //jesli wybierzemy opcję mniejszą niż opcja dziesietna,to...
                    if (bs_lewa_podstawa <= 10)
                    {
                        
                        bs_L = bs_L * bs_lewa_podstawa + (bs_Cyfra - '0');//-'0'
                    }
                    else
                    {
                        if ((bs_Cyfra >= '0') && (bs_Cyfra <= '9'))
                            bs_L = bs_L * bs_lewa_podstawa + (bs_Cyfra-'0');//-'0'
                        else
                        {
                            bs_Cyfra = char.ToUpper(bs_Cyfra);
                            bs_L=bs_L *bs_lewa_podstawa+((bs_Cyfra-'A')+10);
                        }
                    }
                }
            } // koncowa klamra glownego if'a
            int bs_index = 0;
            int bs_wartosc_cyfry = 0;
            while (bs_L > 0)
            {
                if (bs_prawa_podstawa <= 10)
                {
                    bs_Cyfra = (char)((bs_L % bs_prawa_podstawa) + (int)'0');
                    bs_L = bs_L / bs_prawa_podstawa;
                }
                else
                {
                    bs_wartosc_cyfry = bs_L % bs_prawa_podstawa;
                    bs_L = bs_L / bs_prawa_podstawa;
                    if (bs_wartosc_cyfry < 10)
                    {
                        bs_Cyfra = (char)(bs_wartosc_cyfry + (int)'0');
                    }
                    else
                    { 
                        bs_Cyfra = (char)((bs_wartosc_cyfry-10) + 'A');
                    }
                
                }
                bs_tablica_cyfr[bs_index] = bs_Cyfra;
                bs_index++;
            }
            bs_liczba_po_konwersji = "";
            for (int bs_i = bs_index - 1; bs_i >= 0; bs_i--)
            {
                bs_liczba_po_konwersji = bs_liczba_po_konwersji + bs_tablica_cyfr[bs_i];
                wynik_po_konwersji.Text = bs_liczba_po_konwersji.ToString();

            }
            errorProvider1.Dispose();
        }
        //zabezpieczenie przez wpisanie nieprawidłoweych wartosc
        private bool CzyLiczbaJestZapisanaPoprawnie(string bs_lewa, int bs_lewa_podstawa)
        {
            //po wyborze dziesietnym...
            if (bs_lewa_podstawa == 10)
            {
                try
                {
                    bs_liczba = Convert.ToInt32(bs_lewa, bs_lewa_podstawa);
                }
                catch (Exception)
                {
                    errorProvider2.SetError(wpisz_liczbe,"Zodzwolone tylko liczby dziesiętne");
                    return false;
                }
            }
            //po wyborze oktalnym...
            if (bs_lewa_podstawa == 8)
            {
                try
                {
                    bs_liczba = Convert.ToInt32(bs_lewa, bs_lewa_podstawa);
                }
                catch (Exception)
                {
                    errorProvider2.SetError(wpisz_liczbe,"Dozwolone tylko liczby oktalne");
                    return false;
                }
            }
            //po wyborze binarnym
            if (bs_lewa_podstawa == 2)
                try
                {
                    bs_liczba = Convert.ToInt32(bs_lewa, bs_lewa_podstawa);
                }
                catch (Exception)
                {
                    errorProvider2.SetError(wpisz_liczbe, "Dozwolone tylko liczby binarne");
                    return false;
                }
            //po wyborze keksadecymalnym
            if (bs_lewa_podstawa == 16)
                try
                {
                    bs_liczba = Convert.ToInt32(bs_lewa, bs_lewa_podstawa);
                }
                catch (Exception)
                {
                    errorProvider2.SetError(wpisz_liczbe, "Dozwolone tylko liczby heksadecymalne");
                    return false;
                }
            return true;
         }

        private void konwerter_liczb_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult bs_pytanie = MessageBox.Show("Czy chcesz zakończyć?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
           if (bs_pytanie == DialogResult.Yes)
           {
               e.Cancel = false;
           }
           else
           {
               if (bs_pytanie == DialogResult.No)
               {
                   e.Cancel = true;
               }
           }
            
        }
    }
}
