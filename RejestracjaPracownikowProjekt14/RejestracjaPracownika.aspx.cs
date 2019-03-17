using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RejestracjaPracownika : System.Web.UI.Page
{

    private BusinessLayer warstwa_biznesowa = new BusinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        KomunikatNiepoprawneDanePracownik.Visible = false;
        KomunikatNiepowodzenieRejestracjiPracownik.Visible = false;
        KomunikatPowodzenieRejestracjiPraconik.Visible = false;
        KomunikatWymaganePolaPracownik.Visible = false;

        ListaZarejestrowanychPraconikowGrid.Visible = true;
        ListaZarejestrowanychPraconikowGrid.DataSource = warstwa_biznesowa.BLWyswietlPracownikaZJednegoDzialu();
        ListaZarejestrowanychPraconikowGrid.DataBind();


    }

    protected void RejestrujBtn_Click(object sender, EventArgs e)
    {
        int imieCheck = PolaPracownika.ImiePrac;
        int nazwiskoCheck = PolaPracownika.NazwiskoPrac;

        if (ImiePracownikaTxb.Text == null || ImiePracownikaTxb.Text == "" |
            NazwiskoPracownikaTxb.Text == null || NazwiskoPracownikaTxb.Text == "" ||
            ListaDzialowDdl.Text == null || ListaDzialowDdl.Text == "")
        {
            KomunikatWymaganePolaPracownik.Visible = true;

            KomunikatNiepoprawneDanePracownik.Visible = false;
            KomunikatNiepowodzenieRejestracjiPracownik.Visible = false;
            KomunikatPowodzenieRejestracjiPraconik.Visible = false;

            ListaZarejestrowanychPraconikowGrid.Visible = true;
            ListaZarejestrowanychPraconikowGrid.DataSource = warstwa_biznesowa.BLWyswietlPracownikaZJednegoDzialu();
            ListaZarejestrowanychPraconikowGrid.DataBind();

        }
        else if (int.TryParse(ImiePracownikaTxb.Text, out imieCheck) == true ||
            int.TryParse(NazwiskoPracownikaTxb.Text, out nazwiskoCheck) == true)
        {
            KomunikatNiepoprawneDanePracownik.Visible = true;

            KomunikatNiepowodzenieRejestracjiPracownik.Visible = false;
            KomunikatPowodzenieRejestracjiPraconik.Visible = false;
            KomunikatWymaganePolaPracownik.Visible = false;

            ListaZarejestrowanychPraconikowGrid.Visible = true;
            ListaZarejestrowanychPraconikowGrid.DataSource = warstwa_biznesowa.BLWyswietlPracownikaZJednegoDzialu();
            ListaZarejestrowanychPraconikowGrid.DataBind();
        }
        else
        {
            string imie_str = ImiePracownikaTxb.Text;
            string nazwisko_str = NazwiskoPracownikaTxb.Text;
            int id_dzialu = ListaDzialowDdl.SelectedIndex;
            id_dzialu = id_dzialu + 2;
            CzyZarejestrowanoPracownika.CzyZarPrac = warstwa_biznesowa.BLDodajPracownika(imie_str,nazwisko_str,id_dzialu);
            if (CzyZarejestrowanoPracownika.CzyZarPrac == true)
            {
                
                KomunikatNiepoprawneDanePracownik.Visible = false;
                KomunikatNiepowodzenieRejestracjiPracownik.Visible = false;
                KomunikatPowodzenieRejestracjiPraconik.Visible = true;
                KomunikatWymaganePolaPracownik.Visible = false;

                ListaZarejestrowanychPraconikowGrid.Visible = true;
                ListaZarejestrowanychPraconikowGrid.DataSource = warstwa_biznesowa.BLWyswietlPracownikaZJednegoDzialu();
                ListaZarejestrowanychPraconikowGrid.DataBind();


            }
            else
            {
                KomunikatNiepoprawneDanePracownik.Visible = false;
                KomunikatNiepowodzenieRejestracjiPracownik.Visible = true;
                KomunikatPowodzenieRejestracjiPraconik.Visible = false;
                KomunikatWymaganePolaPracownik.Visible = false;

                ListaZarejestrowanychPraconikowGrid.Visible = true;
                ListaZarejestrowanychPraconikowGrid.DataSource = warstwa_biznesowa.BLWyswietlPracownikaZJednegoDzialu();
                ListaZarejestrowanychPraconikowGrid.DataBind();

                
            }
            
        }
    }

    protected void doAdminaBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Administrator.aspx");
    }
}