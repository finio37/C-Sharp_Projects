using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator : System.Web.UI.Page
{

    private BusinessLayer warstwa_biznesowa = new BusinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelLogowaniaAdminaPnl.Visible = true;

        PanelForm.Visible = false;
        KomunikatNiepoprawneDaneAdmPnl.Visible = false;
        KomunikatNiepowodzenieLogowaniaAdmPnl.Visible = false;
        KomunikatPowodzenieLogowaniaAdmPnl.Visible = false;
        KomunikatWymaganePolaAdmPnl.Visible = false;
        bsLoginAdmGrid.Visible = false;

        KomunikatWylogowaniaAdmPnl.Visible = false;
        ZalogujAdmBtn.Visible = true;
        PanelLogowaniaAdminaPnl.Visible = true;

        KomunikatNiepowodzenieDodaniaSzAdmPnl.Visible = false;
        KomunikatPoprawnoscSzAdmPnl.Visible = false;
        KomunikatPowodzenieDodaniaSzAdmPnl.Visible = false;
        KomunikatWymaganePolaSzAdmPnl.Visible = false;

        SzczegolyPracownikowGrid.Visible = false;
    }

    protected void DzialyDDLAdmin_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void DzialyDDLAdmin_Load(object sender, EventArgs e)
    {
        
    }

    protected void ZalogujAdmBtn_Click(object sender, EventArgs e)
    {
        int logCheck = AdministratorPola.LogAdmCheck;
        int hasCheck = AdministratorPola.HasAdmCheck;

        if (LoginAdmTxb.Text == null || LoginAdmTxb.Text == "" ||
            HasloAdmTxb.Text == null || HasloAdmTxb.Text == "")
        {
            KomunikatWymaganePolaAdmPnl.Visible = true;

            PanelForm.Visible = false;
            KomunikatNiepoprawneDaneAdmPnl.Visible = false;
            KomunikatNiepowodzenieLogowaniaAdmPnl.Visible = false;
            KomunikatPowodzenieLogowaniaAdmPnl.Visible = false;
            KomunikatWylogowaniaAdmPnl.Visible = false;
            PanelLogowaniaAdminaPnl.Visible = true;
            ZalogujAdmBtn.Visible = true;
            SzczegolyPracownikowGrid.Visible = false;

        }
        else if (int.TryParse(LoginAdmTxb.Text, out logCheck) == true ||
            int.TryParse(HasloAdmTxb.Text, out hasCheck) == true)
        {
            KomunikatNiepoprawneDaneAdmPnl.Visible = true;

            PanelForm.Visible = false;
            KomunikatNiepowodzenieLogowaniaAdmPnl.Visible = false;
            KomunikatPowodzenieLogowaniaAdmPnl.Visible = false;
            KomunikatWymaganePolaAdmPnl.Visible = false;
            KomunikatWylogowaniaAdmPnl.Visible = false;
            PanelLogowaniaAdminaPnl.Visible = true;
            ZalogujAdmBtn.Visible = true;
            SzczegolyPracownikowGrid.Visible = false;
        }
        else
        {
            string login_str = LoginAdmTxb.Text;
            string haslo_str = HasloAdmTxb.Text;

            PanelForm.Visible = true;
            bsLoginAdmGrid.Visible = true;

            bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(login_str,haslo_str);
            bsLoginAdmGrid.DataBind();
            AdministratorPola.AdminLogin = login_str;
            AdministratorPola.AdminHaslo = haslo_str;

            KomunikatPowodzenieLogowaniaAdmPnl.Visible = true;

            KomunikatNiepoprawneDaneAdmPnl.Visible = false;
            KomunikatNiepowodzenieLogowaniaAdmPnl.Visible = false;
            
            KomunikatWymaganePolaAdmPnl.Visible = false;
            KomunikatWylogowaniaAdmPnl.Visible = false;
            PanelLogowaniaAdminaPnl.Visible = false;
            ZalogujAdmBtn.Visible = false;

            SzczegolyPracownikowGrid.Visible = true;
            SzczegolyPracownikowGrid.DataSource = warstwa_biznesowa.BLWyswietlSzczegoloweDanePracownikow();
            SzczegolyPracownikowGrid.DataBind();
        }
        
    }

    protected void bsWylogujAdminaBtn_Click(object sender, EventArgs e)
    {
        PanelLogowaniaAdminaPnl.Visible = true;
        KomunikatWylogowaniaAdmPnl.Visible = true;

        PanelForm.Visible = false;
        bsLoginAdmGrid.Visible = false;
        KomunikatPowodzenieLogowaniaAdmPnl.Visible = false;
        KomunikatNiepoprawneDaneAdmPnl.Visible = false;
        KomunikatNiepowodzenieLogowaniaAdmPnl.Visible = false;
        KomunikatWymaganePolaAdmPnl.Visible = false;

        AdministratorPola.AdminLogin = null;
        AdministratorPola.AdminHaslo = null;

        SzczegolyPracownikowGrid.Visible = false;
        
    }

    protected void PowrotDoRejestracjiPracownikaBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("RejestracjaPracownika.aspx");
    }

    protected void bsDodajDodatkoweDanePracownikaAdmBtn_Click(object sender, EventArgs e)
    {

        PanelLogowaniaAdminaPnl.Visible = false;
        ZalogujAdmBtn.Visible = false;
        PanelForm.Visible = true;

        bsLoginAdmGrid.Visible = true;

        bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(AdministratorPola.AdminLogin, AdministratorPola.AdminHaslo);
        bsLoginAdmGrid.DataBind();



        int kodCheck = PolaAdresowe.KodPoczt;
        int miastoCheck = PolaAdresowe.Miasto;
        int ulicaCheck = PolaAdresowe.Ulica;

        if (KodPocztowyAdmTxb.Text == null || KodPocztowyAdmTxb.Text == "" ||
            MiastoAdmTxb.Text == null || MiastoAdmTxb.Text == "" ||
           UlicaAdmTxb.Text == null || UlicaAdmTxb.Text == "")
        {
            KomunikatWymaganePolaSzAdmPnl.Visible = true;

            KomunikatNiepowodzenieDodaniaSzAdmPnl.Visible = false;
            KomunikatPoprawnoscSzAdmPnl.Visible = false;
            KomunikatPowodzenieDodaniaSzAdmPnl.Visible = false;

            PanelLogowaniaAdminaPnl.Visible = false;
            ZalogujAdmBtn.Visible = false;
            PanelForm.Visible = true;

            bsLoginAdmGrid.Visible = true;

            bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(AdministratorPola.AdminLogin, AdministratorPola.AdminHaslo);
            bsLoginAdmGrid.DataBind();

            SzczegolyPracownikowGrid.Visible = false;


        }
        else if (int.TryParse(KodPocztowyAdmTxb.Text, out kodCheck) == false ||
            int.TryParse(MiastoAdmTxb.Text, out miastoCheck) == true ||
            int.TryParse(UlicaAdmTxb.Text, out ulicaCheck) == true)
        {
            KomunikatPoprawnoscSzAdmPnl.Visible = true;

            KomunikatWymaganePolaSzAdmPnl.Visible = false;
            KomunikatNiepowodzenieDodaniaSzAdmPnl.Visible = false;
            KomunikatPowodzenieDodaniaSzAdmPnl.Visible = false;

            PanelLogowaniaAdminaPnl.Visible = false;
            ZalogujAdmBtn.Visible = false;
            PanelForm.Visible = true;
            bsLoginAdmGrid.Visible = true;

            bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(AdministratorPola.AdminLogin, AdministratorPola.AdminHaslo);
            bsLoginAdmGrid.DataBind();

            SzczegolyPracownikowGrid.Visible = false;
        }
        else
        {
            string imie_str = ImieDDLAdm.Text;

            int id_pracownika = warstwa_biznesowa.BLWyswietlIdPracownika(imie_str);

            int kod_int = Convert.ToInt32(KodPocztowyAdmTxb.Text);
            string miasto_str = MiastoAdmTxb.Text;
            string ulica_str = UlicaAdmTxb.Text;



            CzyDodanoSzczegoly.CzyDodanoSzcz = warstwa_biznesowa.BLDodajSzczegolyPracownika(kod_int,miasto_str,ulica_str,id_pracownika);
            if (CzyDodanoSzczegoly.CzyDodanoSzcz == true)
            {
                KomunikatPowodzenieDodaniaSzAdmPnl.Visible = true;

                KomunikatPoprawnoscSzAdmPnl.Visible = false;
                KomunikatWymaganePolaSzAdmPnl.Visible = false;
                KomunikatNiepowodzenieDodaniaSzAdmPnl.Visible = false;

                PanelLogowaniaAdminaPnl.Visible = false;
                ZalogujAdmBtn.Visible = false;
                PanelForm.Visible = true;

                bsLoginAdmGrid.Visible = true;

                bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(AdministratorPola.AdminLogin, AdministratorPola.AdminHaslo);
                bsLoginAdmGrid.DataBind();

                SzczegolyPracownikowGrid.Visible = true;
                SzczegolyPracownikowGrid.DataSource = warstwa_biznesowa.BLWyswietlSzczegoloweDanePracownikow();
                SzczegolyPracownikowGrid.DataBind();

            }
            else
            {
                KomunikatPowodzenieDodaniaSzAdmPnl.Visible = false;

                KomunikatPoprawnoscSzAdmPnl.Visible = false;
                KomunikatWymaganePolaSzAdmPnl.Visible = false;
                KomunikatNiepowodzenieDodaniaSzAdmPnl.Visible = true;

                bsLoginAdmGrid.Visible = true;

                bsLoginAdmGrid.DataSource = warstwa_biznesowa.BLWyswietlLoginAdmina(AdministratorPola.AdminLogin, AdministratorPola.AdminHaslo);
                bsLoginAdmGrid.DataBind();

                SzczegolyPracownikowGrid.Visible = true;
                SzczegolyPracownikowGrid.DataSource = warstwa_biznesowa.BLWyswietlSzczegoloweDanePracownikow();
                SzczegolyPracownikowGrid.DataBind();
            }
        }
    }
}