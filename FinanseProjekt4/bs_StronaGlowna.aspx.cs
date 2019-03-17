using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StronaGlowna : System.Web.UI.Page
{
    private bs_BusinessLayer bs_warstwa_biznesowa = new bs_BusinessLayer();
    
    protected void Page_Load(object sender, EventArgs e)
    {

        bs_StatusLogowania.Text = "Nie, nie jesteś zalogowany/na";
        bs_twojLoginLbl.Text = "Nikt";
        bs_OpcjaRejestracjiPnl.Visible = true;
        bs_ErrorWypelnienieWymaganychPolPL.Visible = false;
        bs_ErrorPoprawnosciDanychPL.Visible = false;
        bs_WylogujBtn.Visible = false;
        //bs_ErrorPoprawnosciDanych.Visible = false;

        //bs_ErrorWypelnieniaPol.Visible = false;
        

    }

    protected void bs_zalogujBtn_Click(object sender, EventArgs e)
    {
        bs_KlasaUzytkownika bs_obiekt_uzytkownika = new bs_KlasaUzytkownika();
        string bs_login_str = bs_loginTxb.Text;
        string bs_haslo_str = bs_hasloTbx.Text;
        if ((bs_login_str == "" || bs_login_str == null) || (bs_haslo_str == "" || bs_haslo_str == null))
        {
            bs_FormularzLogowaniaPnl.Visible = true;
            bs_ErrorWypelnienieWymaganychPolPL.Visible = true;
            bs_ErrorPoprawnosciDanychPL.Visible = false;
            
        }
        else
        {
            bs_obiekt_uzytkownika = bs_warstwa_biznesowa.bs_BalWyswietlMojLogin(bs_login_str, bs_haslo_str);
            //bool bs_czy_istniejeTakiRekordBool = bs_warstwa_biznesowa.bs_BLCzyIstniejeTakiRekord(bs_login_str, bs_haslo_str);
            
            if (bs_obiekt_uzytkownika.bsLogin == null && bs_obiekt_uzytkownika.bsHaslo==null)
            {
                bs_StatusLogowania.Text = "Nie, nie jesteś zalogowany/na";
                bs_twojLoginLbl.Text = "Nikt";
                bs_ErrorWypelnienieWymaganychPolPL.Visible = false;
                //bs_ErrorPoprawnosciDanychPL.Visible = false;
                bs_ErrorPoprawnosciDanychPL.Visible = true;
            }
            else
            {
                bs_twojLoginLbl.Text = bs_obiekt_uzytkownika.bsLogin;
                bs_FormularzLogowaniaPnl.Visible = false;
                bs_ObliczanieKosztuKapitaluLink.Visible = true;
                //bs_ZmienneStopyProcentoweLink.Visible = true;
                bs_StatusLogowania.Text = "Tak, jesteś zalogowany/na";
                bs_zalogujBtn.Visible = false;
                bs_OpcjaRejestracjiPnl.Visible = false;
                bs_InfoKorzystaniaZeStrony.Visible = false;
                //bs_ErrorPoprawnosciDanychPL.Visible = false;
                bs_WylogujBtn.Visible = true;
                GridView1.Visible = true;
                bs_ErrorPoprawnosciDanychPL.Visible = false;
                bs_ErrorWypelnienieWymaganychPolPL.Visible = false;

            }
        }
        GridView1.DataSource = bs_warstwa_biznesowa.bs_WyswietlwGridzie(bs_login_str, bs_haslo_str);
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs_FormularzLogowaniaPnl.Visible = true;
        bs_StronaRejestracjiLink.Visible = true;
        bs_twojLoginLbl.Text = "Nikt";
        bs_StatusLogowania.Text = "Nie, nie jesteś zalogowany/na";
        bs_zalogujBtn.Visible = true;
        bs_OpcjaRejestracjiPnl.Visible = true;
        bs_InfoKorzystaniaZeStrony.Visible = true;
        GridView1.Visible = false;
        bs_loginTxb.Text = "";
        bs_hasloTbx.Text = "";
        bs_ObliczanieKosztuKapitaluLink.Visible = false;
        //bs_ZmienneStopyProcentoweLink.Visible = false;
    }
}