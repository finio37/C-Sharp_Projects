using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankomatProjekt15
{
    public partial class Form1 : Form
    {
        //definiowanie ziennych
        Label bs_DolnaGranicaPrzedzialu = new Label();
        Label bs_GornaGrafnicaPrzedzialu = new Label();
        TextBox bs_txtDolnaGranicaPrzedzialu = new TextBox();
        TextBox bs_txtGornaGranicaPrzedzialu = new TextBox();
        Label bs_komunikat_wartosci_losowe = new Label();
        int bs_dolna_granica;
        int bs_gorna_granica;
        Button bs_los_lista = new Button();
        Button bs_btnAkceptacjaNominalow = new Button();
        int[,] bs_NominalyBankomatu = {
        {25,200},{25,100},{25,50},{25,20},{25,10},
        {25,5},{25,2},{25,1}};
        
        int bs_wyplacona_wartosc;
        bool[] bs_StanTabPage = { true, false, false };
        int bs_i = 0;
       //definicja stałej 
        const int bs_NajmniejszyBanknot=10;
        int bs_pieniadze_do_wyplaty;
        int bs_ilosc_nominalow;
        //definicja zmiennej losowej
        Random bs_rnd1 = new Random();
        public Form1()
        {
            InitializeComponent();
            bs_cmbRodzajWaluty.SelectedIndex = 0;
            this.tabControl1.SelectedTab = tabPage1;
            this.radioSt25.Checked = false;
            this.radioUstawieniaLosowe.Checked = false;
        }

        //********************************************************
        //funkcje form1_load oraz combobox1_selectedindexchanged
        //stworzylem niechcacy - prosze nie kasowac,
        //bo inaczej aplikacja nie ruszy
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //**************************************************************
        //ustawienie właściwość dla obiektow dynamicznych
        private void radioUstawieniaLosowe_CheckedChanged(object sender, EventArgs e)
        {
            
            bs_DolnaGranicaPrzedzialu.Text = "Etykieta dolnej granicy przedzialu";
            bs_DolnaGranicaPrzedzialu.Font = new Font(FontFamily.GenericSansSerif,10,FontStyle.Italic);
            bs_DolnaGranicaPrzedzialu.TextAlign = ContentAlignment.MiddleCenter;
            bs_DolnaGranicaPrzedzialu.Location = new Point(140,170);
                bs_DolnaGranicaPrzedzialu.Size = new System.Drawing.Size(200,70);
            this.tabControl1.SelectedTab.Controls.Add(bs_DolnaGranicaPrzedzialu);
            bs_txtDolnaGranicaPrzedzialu.BackColor = Color.White;
            bs_txtDolnaGranicaPrzedzialu.ForeColor = Color.Black;
            bs_txtDolnaGranicaPrzedzialu.Text = "";
            bs_txtDolnaGranicaPrzedzialu.Font = new Font(FontFamily.GenericSansSerif,12.52f,FontStyle.Regular);
            bs_txtDolnaGranicaPrzedzialu.TextAlign = HorizontalAlignment.Center;
                bs_txtDolnaGranicaPrzedzialu.Location = new Point(190,240);
            bs_txtDolnaGranicaPrzedzialu.Size = new System.Drawing.Size(100,70);
            bs_txtDolnaGranicaPrzedzialu.BorderStyle = BorderStyle.FixedSingle;
            this.tabControl1.SelectedTab.Controls.Add(bs_txtDolnaGranicaPrzedzialu);

            
            bs_GornaGrafnicaPrzedzialu.Text = "Górna granica przedziału nominałów";
            bs_GornaGrafnicaPrzedzialu.Font = new Font(FontFamily.GenericSansSerif, 10.25f, FontStyle.Italic);
            bs_GornaGrafnicaPrzedzialu.TextAlign = ContentAlignment.MiddleCenter;
            bs_GornaGrafnicaPrzedzialu.Location = new Point(400,170);
            bs_GornaGrafnicaPrzedzialu.Size = new System.Drawing.Size(200,70);
            this.tabControl1.SelectedTab.Controls.Add(bs_GornaGrafnicaPrzedzialu);


            
            bs_txtGornaGranicaPrzedzialu.BackColor = Color.White;
            bs_txtGornaGranicaPrzedzialu.ForeColor = Color.Black;
            bs_txtGornaGranicaPrzedzialu.Text = "";
            bs_txtGornaGranicaPrzedzialu.Font = new Font(FontFamily.GenericSansSerif, 10.25f, FontStyle.Italic);
            bs_txtGornaGranicaPrzedzialu.TextAlign = HorizontalAlignment.Center;
            bs_txtGornaGranicaPrzedzialu.Location = new Point(460, 240);
            bs_txtGornaGranicaPrzedzialu.Size = new System.Drawing.Size(100,70);
            bs_txtGornaGranicaPrzedzialu.BorderStyle = BorderStyle.FixedSingle;
            this.tabControl1.SelectedTab.Controls.Add(bs_txtGornaGranicaPrzedzialu);

            bs_los_lista.BackColor = Color.White;
            bs_los_lista.ForeColor = Color.Black;
            bs_los_lista.Text = "Przejdź do tabeli";
            bs_los_lista.Font = new Font(FontFamily.GenericSansSerif,10.25f,FontStyle.Italic);
            bs_los_lista.Size = new System.Drawing.Size(200,30);
            bs_los_lista.Location = new Point(270,270);
            this.tabControl1.SelectedTab.Controls.Add(bs_los_lista);
            bs_los_lista.Click += new EventHandler(bs_los_lista_Click);

            bs_komunikat_wartosci_losowe.BackColor = Color.White;
            bs_komunikat_wartosci_losowe.ForeColor = Color.Black;
            bs_komunikat_wartosci_losowe.Text = "";
            bs_komunikat_wartosci_losowe.Font = new Font(FontFamily.GenericSansSerif,12,FontStyle.Regular);
            bs_komunikat_wartosci_losowe.Size = new System.Drawing.Size(300,30);
            bs_komunikat_wartosci_losowe.Location = new Point(250,300);
            this.tabControl1.SelectedTab.Controls.Add(bs_komunikat_wartosci_losowe);
            }

        //funkcja obsługujace opcję domyslna
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab.Controls.Remove(bs_DolnaGranicaPrzedzialu);
            this.tabControl1.SelectedTab.Controls.Remove(bs_GornaGrafnicaPrzedzialu);
            this.tabControl1.SelectedTab.Controls.Remove(bs_txtDolnaGranicaPrzedzialu);
            this.tabControl1.SelectedTab.Controls.Remove(bs_txtGornaGranicaPrzedzialu);

            
            for (bs_i = 0; bs_i < bs_NominalyBankomatu.GetLength(0);bs_i++ )
            {
                dgwListaWyplaty.Rows.Add();
                dgwListaWyplaty.Rows[bs_i].Cells[0].Value = bs_NominalyBankomatu[bs_i,0];
                dgwListaWyplaty.Rows[bs_i].Cells[1].Value = bs_NominalyBankomatu[bs_i,1];

                
                if (bs_NominalyBankomatu[bs_i,1]>=bs_NajmniejszyBanknot)
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value = "Banknot";
                }
                else
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value= "Moneta";
                }
                if (bs_cmbRodzajWaluty.SelectedIndex==0)
                {
                    
                    dgwListaWyplaty.Rows[bs_i].Cells[3].Value = "PLN";
                }
                else if (bs_cmbRodzajWaluty.SelectedIndex==1) 
                {

                    dgwListaWyplaty.Rows[bs_i].Cells[3].Value = "USD";
                } 
            }
            bs_StanTabPage[2] = true;
            bs_StanTabPage[1] = false;
            bs_StanTabPage[0] = false;


            //bs_nowa_wyplata.Visible = false;
            tabControl1.SelectedTab = tabPage3;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //funkcja do przechodzenie miedzy zakladkami i blokowania ich
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabControl1.TabPages[0])
            {
                e.Cancel = true;
            }
            else if (e.TabPage == tabControl1.TabPages[1])
            {
                if (bs_StanTabPage[1])
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.TabPage == tabControl1.TabPages[2])
            {
                if (bs_StanTabPage[2])
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }
               
        }

        private void rezygnacja_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //funkcja wykonujaca wyplate
        private void akceptacja_Click(object sender, EventArgs e)
        {
            try
            {
                bs_pieniadze_do_wyplaty = Convert.ToInt32(bs_kwota_do_wyplaty.Text);
            }
            catch
            {
                komunikat.Text = "Wprowadzono nieprawidłowe dane";
                bs_kwota_do_wyplaty.ForeColor = Color.Red;
                return;
            }
            if (bs_pieniadze_do_wyplaty <= 0)
            {
                komunikat.Text = "Wartości ujemne lub równe zero - zabronione";
                bs_kwota_do_wyplaty.ForeColor = Color.Red;
                return;
            }
            while (bs_pieniadze_do_wyplaty > 0)
            {
                
                    for (bs_i = 0; bs_i < bs_NominalyBankomatu.GetLength(0); bs_i++)
                    {
                        bs_ilosc_nominalow = Convert.ToInt16(bs_pieniadze_do_wyplaty / bs_NominalyBankomatu[bs_i, 1]);
                        if (bs_ilosc_nominalow > (bs_NominalyBankomatu[bs_i, 0]))
                        {
                            bs_ilosc_nominalow = Convert.ToInt32(bs_NominalyBankomatu[bs_i, 0]);

                        }
                        else
                        {
                            bs_NominalyBankomatu[bs_i, 0] = bs_ilosc_nominalow;
                        }
                        dgwListaWyplaty.Rows.Add();
                        dgwListaWyplaty.Rows[bs_i].Cells[0].Value = bs_NominalyBankomatu[bs_i, 0];
                        dgwListaWyplaty.Rows[bs_i].Cells[1].Value = bs_NominalyBankomatu[bs_i, 1];
                        bs_pieniadze_do_wyplaty = bs_pieniadze_do_wyplaty - bs_NominalyBankomatu[bs_i, 0] * bs_NominalyBankomatu[bs_i, 1];
                        if (bs_ilosc_nominalow != 0)
                        {
                            bs_wyplacona_wartosc = bs_wyplacona_wartosc + bs_ilosc_nominalow * bs_NominalyBankomatu[bs_i, 1]; 
                        }
                        
                    }
               }            

            bs_StanTabPage[0] = false;
            bs_StanTabPage[1] = false;
            bs_StanTabPage[2] = true;

            tabControl1.SelectedTab = tabPage3;
            
            bs_koniec.Visible = true;
            bs_wyplac.Visible = false;
            bs_komunikat_koncowy.Visible = true;
            bs_wyplacona_kwota_komunikat.Text = Convert.ToString(bs_wyplacona_wartosc);
            bs_wyplacona_kwota_left.Visible = true;
            bs_wyplacona_kwota_komunikat.Visible = true;
           }

        //funkcja przekierowujaca do zaladki z wyplacaniem
        private void resetuj_Click(object sender, EventArgs e)
        {
            for (bs_i = 0; bs_i < bs_NominalyBankomatu.GetLength(0); bs_i++)
            {
                dgwListaWyplaty.Rows.Add();
                dgwListaWyplaty.Rows[bs_i].Cells[0].Value = bs_NominalyBankomatu[bs_i, 0];
                dgwListaWyplaty.Rows[bs_i].Cells[1].Value = bs_NominalyBankomatu[bs_i, 1];
                if (bs_NominalyBankomatu[bs_i, 1] >= bs_NajmniejszyBanknot)
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value = "Banknot";
                }
                else
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value = "Moneta";
                }
                
            }
            bs_StanTabPage[0] = false;
            bs_StanTabPage[1] = true;
            bs_StanTabPage[2] = false;
            tabControl1.SelectedTab = tabPage2;
        }
        
        //funkcja losujaca ilosc nominalow
        private void bs_los_lista_Click(object sender, EventArgs e)
        {
            try
            {
                bs_dolna_granica = Convert.ToInt32(bs_txtDolnaGranicaPrzedzialu.Text);
            }
            catch
            {
                bs_komunikat_wartosci_losowe.Text = "Wprowadzono nie prawidłowe watości";
                bs_txtDolnaGranicaPrzedzialu.ForeColor = Color.Red;
                return;
                
            }
            try
            {
                bs_gorna_granica = Convert.ToInt32(bs_txtGornaGranicaPrzedzialu.Text);
            }
            catch
            {
                bs_komunikat_wartosci_losowe.Text = "Wprowadzono nie prawidłowe wartości";
                bs_txtGornaGranicaPrzedzialu.ForeColor = Color.Red;
                return;
            }
                      
            for (bs_i = 0; bs_i < bs_NominalyBankomatu.GetLength(0); bs_i++)
            {
                bs_NominalyBankomatu[bs_i, 0] = bs_rnd1.Next(bs_dolna_granica,bs_gorna_granica);

                dgwListaWyplaty.Rows.Add();
                dgwListaWyplaty.Rows[bs_i].Cells[0].Value = bs_NominalyBankomatu[bs_i, 0];
                dgwListaWyplaty.Rows[bs_i].Cells[1].Value = bs_NominalyBankomatu[bs_i, 1];


                if (bs_NominalyBankomatu[bs_i, 1] >= bs_NajmniejszyBanknot)
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value = "Banknot";
                }
                else
                {
                    dgwListaWyplaty.Rows[bs_i].Cells[2].Value = "Moneta";
                }
                if (bs_cmbRodzajWaluty.SelectedIndex == 0)
                {

                    dgwListaWyplaty.Rows[bs_i].Cells[3].Value = "PLN";
                }
                else if (bs_cmbRodzajWaluty.SelectedIndex == 1)
                {

                    dgwListaWyplaty.Rows[bs_i].Cells[3].Value = "USD";
                }
            }
            bs_StanTabPage[2] = true;
            bs_StanTabPage[1] = false;
            bs_StanTabPage[0] = false;



            tabControl1.SelectedTab = tabPage3;


        }

        //funkcja do zerowania pol
        private void wyzeruj_Click(object sender, EventArgs e)
        {
            bs_kwota_do_wyplaty.Text = "";
            bs_kwota_do_wyplaty.Enabled = true;
            bs_kwota_do_wyplaty.Focus();
        }

        //funkcja zieniajaca kolor tekstu w polu
        private void kwota_do_wyplaty_TextChanged(object sender, EventArgs e)
        {
            bs_kwota_do_wyplaty.ForeColor = Color.Black;
            komunikat.Text = "";
        }
        
        //funkcja obslugujaca zamykanie programu
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult bs_pytanie = MessageBox.Show("Czy chcesz zakończyć?",this.Text,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
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
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //funkcja sluzaca do zamykania programu
        private void bs_koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
