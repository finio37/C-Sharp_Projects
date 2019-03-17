using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_StronaRejestracji : System.Web.UI.Page
{
    private bs_BusinessLayer bs_warstwa_biznesowa = new bs_BusinessLayer();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        bs_KomunikatOZarejestrowaniu.Visible = false;
        bs_KomunikatONiezarejestrowaniu.Visible = false;
        bs_ErrorIstnienieTakiUzytkownikPL.Visible = false;
        bs_KomunikatWymaganychPolPL.Visible = false;
        bs_PowrotDoLogowania.Visible = true;
        bs_KomunikatJesliLoginJestInt.Visible = false;



    }

    protected void bs_ZarejestrujBtn_Click(object sender, EventArgs e)
    {
        string bs_login_str = bs_LoginTxb.Text;
        string bs_haslo_str = bs_HasloTxb.Text;
        bool bs_czy_CiagZawieraZnakUnicode;
        int bs_login_int;
        float bs_login_float;
        double bs_login_double;
        
        bs_KlasaUzytkownika bs_obiekt_uzytkownika = new bs_KlasaUzytkownika();
        bs_obiekt_uzytkownika = bs_warstwa_biznesowa.bs_BLCzyJestTakiUzytkownik(bs_login_str,bs_haslo_str);
        // bool bs_czy_IstniejeTakiRekord = bs_warstwa_biznesowa.bs_BLCzyIstniejeTakiRekord(bs_login_str, bs_haslo_str);

        if (bs_login_str == "" || bs_login_str == null || bs_haslo_str == "" || bs_haslo_str == null)
        {
            bs_KomunikatWymaganychPolPL.Visible = true;
            bs_ErrorIstnienieTakiUzytkownikPL.Visible = false;
            bs_KomunikatONiezarejestrowaniu.Visible = false;
            bs_KomunikatOZarejestrowaniu.Visible = false;
            bs_PowrotDoLogowania.Visible = false;

        }
        else
        {

            if (int.TryParse(bs_login_str, out bs_login_int) || (float.TryParse(bs_login_str,out bs_login_float)) || (double.TryParse(bs_login_str,out bs_login_double)) || bs_login_str.Contains(".")==true || bs_login_str.Contains("/")==true || bs_haslo_str.Contains(".")==true || bs_haslo_str.Contains("/")==true)
            {
                bs_KomunikatJesliLoginJestInt.Visible = true;
                bs_KomunikatWymaganychPolPL.Visible = false;
                bs_ErrorIstnienieTakiUzytkownikPL.Visible = false;
                bs_KomunikatONiezarejestrowaniu.Visible = false;
                bs_KomunikatOZarejestrowaniu.Visible = false;
                bs_PowrotDoLogowania.Visible = false;
            }
            else if (bs_obiekt_uzytkownika.bsLogin != null)
            {
                bs_KomunikatJesliLoginJestInt.Visible = false;
                bs_KomunikatWymaganychPolPL.Visible = false;
                bs_ErrorIstnienieTakiUzytkownikPL.Visible = true;
                bs_KomunikatONiezarejestrowaniu.Visible = false;
                bs_KomunikatOZarejestrowaniu.Visible = false;
                bs_PowrotDoLogowania.Visible = false;
            }
            else
            {
                bool bs_czy_DodanoRekordDoBazy = bs_warstwa_biznesowa.bs_BLDodajRekord(bs_login_str, bs_haslo_str);
                if (bs_czy_DodanoRekordDoBazy == true)
                {
                    bs_KomunikatJesliLoginJestInt.Visible = false;
                    bs_KomunikatWymaganychPolPL.Visible = false;
                    bs_ErrorIstnienieTakiUzytkownikPL.Visible = false;
                    bs_KomunikatOZarejestrowaniu.Visible = true;
                    bs_KomunikatONiezarejestrowaniu.Visible = false;
                    bs_PowrotDoLogowania.Visible = false;

                }
                else if (bs_czy_DodanoRekordDoBazy == false)
                {
                    bs_KomunikatJesliLoginJestInt.Visible = false;
                    bs_KomunikatWymaganychPolPL.Visible = false;
                    bs_ErrorIstnienieTakiUzytkownikPL.Visible = false;
                    bs_KomunikatOZarejestrowaniu.Visible = false;
                    bs_KomunikatONiezarejestrowaniu.Visible = true;
                    bs_PowrotDoLogowania.Visible = false;
                }
            }
        }
        

    }
}