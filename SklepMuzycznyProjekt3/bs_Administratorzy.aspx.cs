using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_Administratorzy : System.Web.UI.Page
{
    private bsKlasaUsera bs_obiekt_admina = new bsKlasaUsera();
    private bsAdministrator bs_admin = new bsAdministrator();
    private bsBusinesLayer bs_warstwa_biznesu = new bsBusinesLayer();

    //private bsAdministrator bs_adminHaslo = new bsAdministrator();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        bsGorneMenuAdministracjaPnl.Visible = true;
        bsWymaganePolaAkcesoriaPnl.Visible = false;
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;
        

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl.Visible = false;
        bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        
        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsWymaganePolaDodawanieInstrumentowPnl.Visible = false;
        bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = false;
        bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = false;
        bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsNiepoprawneDaneOpAdmPnl.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsWszystkiePolaModNaglMuszaZostacWypelnione.Visible = false;

        bsWymaganePolaOpAdmPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWpisalesNiepoprawneDaneModNaglPln.Visible = false;
        bsTabelaNaglosnienieAdmGrid.Visible = false;
        bsTabelaNaglosnienieAdmGrid.Visible = false;

        bsGratulacjeModyfikacjaNaglPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaNaglNiepowiodlasie.Visible = false;


        if (bsAdministrator.bswynikZapytania == null)
        {
            Response.Redirect("bs_StronaGlowna.aspx");
        }
        bsAkcesoriaPnl.Visible = true;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;

        bsWylogowaniePnl.Visible = true;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;

        bsWymaganePolaOpModAdmPnl.Visible = false;
        bsPoprawnoscDanychOpAdmPln.Visible = false;

        bsPowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;
        bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;



        bsWymaganePolaStAdmPnl.Visible = false;
        bsNiepoprawneDaneStAdmPnl.Visible = false;
        bsPowodzenieDodaniaStudyjnychDoSklepu.Visible = false;
        bsNiepowodzenieDodaniaStudyjnychDoSklepu.Visible = false;

        bsTabelaStAdmGrid.Visible = false;
        bsKomunikatWymaganePolaModAdmPnl.Visible = false;
        bsKomunikatNiepoprawneDaneStModAdmPnl.Visible = false;
        bsPowodzenieModyfikacjiStudioAdmPnl.Visible = false;
        bsNiepowodzenieModyfikacjiStudioAdmPnl.Visible = false;
        bsKomunikatWymaganePolaWypAdmPnl.Visible = false;
        bsKomunikatNiepoprawneDaneWypAdmPnl.Visible = false;
        bsPowodzenieDodaniaWypAdmPnl.Visible = false;
        bsNiepowodzenieDodaniaWypAdmPnl.Visible = false;

        bsTabelaWyprzedarzyAdmGrid.Visible = false;
        bsKomunikatWymaganePolaModWypAdmPnl.Visible = false;
        bsKomunikatNieprawidloweDaneModWypAdmPnl.Visible = false;

        bsPowodzenieModyfikacjiWypAdmPnl.Visible = false;
        bsNiepowodzenieModyfikacjiWypAdmPnl.Visible = false;

        bsWymaganePolaDspAdmPnl.Visible = false;
        bsNiepoprawneDaneDspAdmPnl.Visible = false;
        bsPowodzenieDodaniaDspAdmPnl.Visible = false;
        bsNiepowodzenieDodaniaDspAdmPnl.Visible = false;

        bsKomunikatWymaganePolaDspModAdmPnl.Visible = false;
        bsKomunikatNiepoprawneDaneDspModAdmPnl.Visible = false;
        bsPowodzenieModyfikacjiDspPnl.Visible = false;
        bsNiepowodzenieModyfikacjiDspPnl.Visible = false;

        bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = false;

        bsTabelaDspAdmGrid.Visible = false;
        bsDspPnl.Visible = false;


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
    }

    protected void bsAkcesoriaAdmBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = true;

        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
        
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;


        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
       
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsTabelaInstrumentowAdmGrid.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = false;

        bsTabelaNaglosnienieAdmGrid.Visible = false;

        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
        bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
        bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
        bsGorneMenuAdministracjaPnl.Visible = true;

        bsWylogowaniePnl.Visible = true;
    }

    protected void bsWylogujBtn_Click(object sender, EventArgs e)
    {
        bsAdministrator.bswynikZapytania = null;
       
        Response.Redirect("bs_StronaGlowna.aspx");

    }

    protected void bsInstrumentyAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = true;
        bsWymaganePolaModPln.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
       
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;

        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        //***********************
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsTabelaNaglosnienieAdmGrid.Visible = false;
        bsTabelaInstrumentowAdmGrid.Visible = true;
        bsTabelaInstrumentowAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleInstrumentowAdmGrid();
        bsTabelaInstrumentowAdmGrid.DataBind();
        //***********************
        bsGorneMenuAdministracjaPnl.Visible = true;

        bsWylogowaniePnl.Visible = true;
    }

    protected void bsNaglosnienieAdmBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = true;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
       

        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;


        bsGorneMenuAdministracjaPnl.Visible = true;



        bsWylogowaniePnl.Visible = true;
        bsTabelaNaglosnienieAdmGrid.Visible = true;
        bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
        bsTabelaNaglosnienieAdmGrid.DataBind();
    }

    protected void bsOprogramowanieAdmBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = true;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
       

        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

       
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsTabelaOprogramowanieAdmGrid.Visible = true;
        bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
        bsTabelaOprogramowanieAdmGrid.DataBind();

        bsGorneMenuAdministracjaPnl.Visible = true;

        bsWylogowaniePnl.Visible = true;
    }

    protected void bsStudioAdmBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;

        bsStudioPnl.Visible = true;
        bsWyprzedarzPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
        

        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGorneMenuAdministracjaPnl.Visible = true;


        bsWylogowaniePnl.Visible = true;

        bsTabelaStAdmGrid.Visible = true;
        bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
        bsTabelaStAdmGrid.DataBind();
    }

    protected void bsWyprzedarzAdmBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWyprzedarzPnl.Visible = true;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
        
        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGorneMenuAdministracjaPnl.Visible = true;
        bsWyprzedarzPnl.Visible = true;

        bsWylogowaniePnl.Visible = true;
        bsTabelaWyprzedarzyAdmGrid.Visible = true;
        bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
        bsTabelaWyprzedarzyAdmGrid.DataBind();

    }

    protected void bsDodajAkcesoriaBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = true;

        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsDspPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;

        
        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        //bool
        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;
        //*****

        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;

        float bs_cenaAkcesoria = bsPolaAkcesoria.bsCenaAkcesoria;
        int bs_nazwaAkcesoria = bsPolaAkcesoria.bsNazwaAkcesoria;
        int bs_kodAkcesoria;
        bsGorneMenuAdministracjaPnl.Visible = true;

        //****
        string bs_nazwaAk, bs_kodAk;
        double bs_cenaAk;
        bool bs_czy_dodano_rekord_do_akcesoriow;
        //***

        if (bsNazwaAkcesoriaTxb.Text == "" || bsNazwaAkcesoriaTxb.Text == null || bsCenaAkcesoriaTxb.Text == "" ||
            bsCenaAkcesoriaTxb.Text == null || bsKodAkcesoriaTxb.TemplateControl == null || bsKodAkcesoriaTxb.Text == "")
        {
            bsWymaganePolaAkcesoriaPnl.Visible = true;
           
            bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

            bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

            bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
            bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
            bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
            bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
        }
        //systuacja wszystkich trzech pol niepoprawnych
        else if (float.TryParse(bsCenaAkcesoriaTxb.Text, out bs_cenaAkcesoria) == false ||
            int.TryParse(bsNazwaAkcesoriaTxb.Text, out bs_nazwaAkcesoria) == true || int.TryParse(bsKodAkcesoriaTxb.Text, out bs_kodAkcesoria) == true)
        {
            bsWymaganePolaAkcesoriaPnl.Visible = false;

            bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = true;
            
            bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
            bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;

            bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
            bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
            bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
            bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
        }
        else
        {
            bs_nazwaAk = bsNazwaAkcesoriaTxb.Text;
            bs_kodAk = bsKodAkcesoriaTxb.Text;
            bs_cenaAk = Convert.ToDouble(bsCenaAkcesoriaTxb.Text);
            bs_czy_dodano_rekord_do_akcesoriow = bs_warstwa_biznesu.bs_BLDodajProduktDoTabeliAkcesoria(bs_nazwaAk,bs_kodAk,(float)bs_cenaAk);
            if (bs_czy_dodano_rekord_do_akcesoriow == true)
            {
                bsWymaganePolaAkcesoriaPnl.Visible = false;
               
                bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

                bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = true;
                bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;
                bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;

                bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

                bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
                bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
            }
            else
            {
                bsWymaganePolaAkcesoriaPnl.Visible = false;
                
                bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
                bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
                bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;

                bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

                bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
                bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
                bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
            }
        }
    }

    protected void bsModyfikujAkcesoriaTxb_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = true;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;

        bsDspPnl.Visible = false;

        int bs_nazwaAkcesCheck, bs_kodAkcesCheck;
        float bs_cenaAkcesCheck;

        int bsIdModAkc;
        string bs_nazwa_akcesoria;
        string bs_kod_akcesoria;
        double bs_cena_akcesoria;
        bool bs_czy_zmodyfikowano_dane_akcesoria;
        bsWymaganePolaAkcesoriaPnl.Visible = false;
        
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

       
        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        //bool
        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;
        //*******

        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
        bsGorneMenuAdministracjaPnl.Visible = true;
        if (bsIdAkcesoriaModyfikacjaTxb.Text == null || bsIdAkcesoriaModyfikacjaTxb.Text == "" ||
            bsNazwaAkcesoriaModyfikacjaTxb.Text == null || bsNazwaAkcesoriaModyfikacjaTxb.Text == "" ||
            bsKodAkcesoriaModyfikacjaTxb.Text == null || bsKodAkcesoriaModyfikacjaTxb.Text == "" ||
            bsCenaAkcesoriaModyfikacjaTxb.Text == null || bsCenaAkcesoriaModyfikacjaTxb.Text == "")
        {
            bsWymaganePolaAkcesoriaPnl.Visible = false;
            
            bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

            bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
            bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

            bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = false;

            

            bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
            bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;



            bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = true;
            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;

            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
            bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
            bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();

        }
        else if (int.TryParse(bsIdAkcesoriaModyfikacjaTxb.Text, out bsIdModAkc) == false ||
            int.TryParse(bsNazwaAkcesoriaModyfikacjaTxb.Text, out bs_nazwaAkcesCheck) == true ||
            int.TryParse(bsKodAkcesoriaModyfikacjaTxb.Text, out bs_kodAkcesCheck) == true ||
            float.TryParse(bsCenaAkcesoriaModyfikacjaTxb.Text, out bs_cenaAkcesCheck) == false)
        {
            
            bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = true;

            bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
            bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

            bsWymaganePolaAkcesoriaPnl.Visible = false;
            
            bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;
            bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
            bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;
            


            bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
            bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
            bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;

            

            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
            bsGorneMenuAdministracjaPnl.Visible = true;

            bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
            bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
            bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
        }
        else
        {
            bsIdModAkc = Convert.ToInt32(bsIdAkcesoriaModyfikacjaTxb.Text);
            bs_nazwa_akcesoria = bsNazwaAkcesoriaModyfikacjaTxb.Text;
            bs_kod_akcesoria = bsKodAkcesoriaModyfikacjaTxb.Text;
            bs_cena_akcesoria = Convert.ToDouble(bsCenaAkcesoriaModyfikacjaTxb.Text);

            bs_czy_zmodyfikowano_dane_akcesoria = bs_warstwa_biznesu.bs_BLModyfikujRekordAkcesoriow(bsIdModAkc,bs_nazwa_akcesoria,bs_kod_akcesoria,(float) bs_cena_akcesoria);
            if (bs_czy_zmodyfikowano_dane_akcesoria == true)
            {
                bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = true;
                bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;

                bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = false;

                
                bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;

                bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
                bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
               
            }
            else
            {
                bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
                bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;

                bsKomunikatNiepoprawneDaneAkcModAdmPnl.Visible = false;

                bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
                

                bsTabelaAdministracyjnaAkcesoriowGrid.Visible = true;
                bsTabelaAdministracyjnaAkcesoriowGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleAkcesoriowAdmGrid();
                bsTabelaAdministracyjnaAkcesoriowGrid.DataBind();
            }

        }
    }

    protected void bsDodajInstrDoSklepuBtn_Click(object sender, EventArgs e)
    {
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsDspPnl.Visible = false;

        bsInstrumentyPnl.Visible = true;
        
        string bs_nazwaDodInstr, bs_kodDodInstr;
        double bs_cenaDodInstr;
        bool bs_czy_dodano_instrument_do_sklepu;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
       
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;

        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        
        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        //bool
        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;
        //*******

        int poleNazInstr_int = bsPolaInstrumenty.PoleNazwaInstr_int;
        int poleKodInstr_int = bsPolaInstrumenty.PoleKodInstr_int;
        float poleCenaInstr_float = bsPolaInstrumenty.PoleCenaInstr_float;

        if (bsNazwaInstrTxb.Text == null || bsNazwaInstrTxb.Text == "" ||
            bsKodInstrTxb.Text == null || bsKodInstrTxb.Text == "" ||
            bsCenaInstrTxb.Text == null || bsCenaInstrTxb.Text == "")
        {
            bsWymaganePolaDodawanieInstrumentowPnl.Visible = true;
            bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = false;
            bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = false;
            bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = false;
        }
        else if (int.TryParse(bsNazwaInstrTxb.Text, out poleNazInstr_int) == true ||
            int.TryParse(bsKodInstrTxb.Text, out poleKodInstr_int) == true ||
            float.TryParse(bsCenaInstrTxb.Text, out poleCenaInstr_float) == false)
        {
            bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = true;
            bsWymaganePolaDodawanieInstrumentowPnl.Visible = false;
            bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = false;
            bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = false;
        }
        else
        {
            bs_nazwaDodInstr = bsNazwaInstrTxb.Text;
            bs_kodDodInstr = bsKodInstrTxb.Text;
            bs_cenaDodInstr = Convert.ToDouble(bsCenaInstrTxb.Text);
            bs_czy_dodano_instrument_do_sklepu = bs_warstwa_biznesu.bs_BLDodajInstrumentDoSklepu(bs_nazwaDodInstr,bs_kodDodInstr,(float)bs_cenaDodInstr);
            if (bs_czy_dodano_instrument_do_sklepu == true)
            {
                bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = true;

                bsWymaganePolaDodawanieInstrumentowPnl.Visible = false;
                bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = false;
                bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = false;
                bsTabelaInstrumentowAdmGrid.Visible = true;
                bsTabelaInstrumentowAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleInstrumentowAdmGrid();
                bsTabelaInstrumentowAdmGrid.DataBind();
            }
            else
            {
                bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = true;

                bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = false;
                bsWymaganePolaDodawanieInstrumentowPnl.Visible = false;
                bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = false;

                bsTabelaInstrumentowAdmGrid.Visible = true;
                bsTabelaInstrumentowAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleInstrumentowAdmGrid();
                bsTabelaInstrumentowAdmGrid.DataBind();

            }

        }
    }

    protected void bsModyfikujInstrBtn_Click(object sender, EventArgs e)
    {
        bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl.Visible = false;

        bsGratulacjeDodanoInstrumentDoSklepuPnl.Visible = false;
        bsWymaganePolaDodawanieInstrumentowPnl.Visible = false;
        bsWprowadzoneDaneSaNiepoprawneInstPnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;
        

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsInstrumentyPnl.Visible = true;
        int bs_idMod = bsPolaInstrumenty.PoleIdInstr_int;
        int bs_nazwaMod = bsPolaInstrumenty.PoleNazwaInstr_int;
        int bs_kodMod = bsPolaInstrumenty.PoleKodInstr_int;
        float bs_CenaMod = bsPolaInstrumenty.PoleCenaInstr_float;

        int bsIdMod_int;
        string bsNazwaMod_str;
        string bsKodMod_str;
        double bsCenaMod_double;
        

        if (bsIdInstrModTxb.Text == null || bsIdInstrModTxb.Text == "" ||
            bsNazwaInstrModTxb.Text == null || bsNazwaInstrModTxb.Text == "" ||
            bsKodInstrModTxb.Text == null || bsKodInstrModTxb.Text == "" ||
                bsCenaInstrModTxb.Text == null || bsCenaInstrModTxb.Text == "")
        {
            bsWymaganePolaModPln.Visible = true;
            bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;
        }
        else if (int.TryParse(bsIdInstrModTxb.Text, out bs_idMod) == false ||
            int.TryParse(bsNazwaInstrModTxb.Text, out bs_nazwaMod) == true ||
            int.TryParse(bsKodInstrModTxb.Text, out bs_kodMod) == true ||
            float.TryParse(bsCenaInstrModTxb.Text, out bs_CenaMod) == false)
        {
            bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = true;

            bsWymaganePolaModPln.Visible = false;
        }
        else
        {
            bsIdMod_int = Convert.ToInt32(bsIdInstrModTxb.Text);
            bsNazwaMod_str = bsNazwaInstrModTxb.Text;
            bsKodMod_str = bsKodInstrModTxb.Text;
            bsCenaMod_double = Convert.ToDouble(bsCenaInstrModTxb.Text);
            bsCzyZmodyfikowanoInstrument.bsCzyZmodyfikowanoInstrumentBool = bs_warstwa_biznesu.bs_BLModyfikujDaneInstrumentu(bsIdMod_int,bsNazwaMod_str, bsKodMod_str, (float)bsCenaMod_double);
            if (bsCzyZmodyfikowanoInstrument.bsCzyZmodyfikowanoInstrumentBool == true)
            {
                bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;
                bsWymaganePolaModPln.Visible = false;

                //bool
                bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = true;
                bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;
                //*******
                bsTabelaInstrumentowAdmGrid.Visible = true;
                bsTabelaInstrumentowAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleInstrumentowAdmGrid();
                bsTabelaInstrumentowAdmGrid.DataBind();

            }
            else
            {
                bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;
                bsWymaganePolaModPln.Visible = false;

                //bool
                bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
                bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = true;
                //*******

                bsTabelaInstrumentowAdmGrid.Visible = true;
                bsTabelaInstrumentowAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleInstrumentowAdmGrid();
                bsTabelaInstrumentowAdmGrid.DataBind();
            }
        }
    }

    protected void bsDodajProdukNaglasniajacyAdmBtn_Click(object sender, EventArgs e)
    {
        bsStudioPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsDspPnl.Visible = false;

        bsNaglosnieniePnl.Visible = true;


        int bsIdN = bsPolaNaglosnienie.bsIdNagl;
        int bsNazwaN = bsPolaNaglosnienie.bsNazwaNaglCheck;
        int bsKodN = bsPolaNaglosnienie.bsKodNaglCheck;
        float bsCenaN = bsPolaNaglosnienie.bsCenaNagl;

        int bsIdN_int;
        string bsNazwaN_str, bsKodN_str;
        double bsCenaN_double;

        if (bsNazwaProduktuNaglTxb.Text == null || bsNazwaProduktuNaglTxb.Text == "" ||
            bsKodProduktuNaglTxb.Text == null || bsKodProduktuNaglTxb.Text == "" ||
            bsCenaProduktuNaglTxb.Text == null || bsCenaProduktuNaglTxb.Text == "")
        {
            bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = true;
            bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;
            bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
            bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;
        }
        else if (int.TryParse(bsNazwaProduktuNaglTxb.Text, out bsNazwaN) == true ||
            int.TryParse(bsKodProduktuNaglTxb.Text, out bsKodN) == true ||
            float.TryParse(bsCenaProduktuNaglTxb.Text, out bsCenaN) == false)
        {
            bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
            bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = true;

            bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
            bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;
        }
        else
        {
            bsNazwaN_str = bsNazwaProduktuNaglTxb.Text;
            bsKodN_str = bsKodProduktuNaglTxb.Text;
            bsCenaN_double = Convert.ToDouble(bsCenaProduktuNaglTxb.Text);
            bsCzyDodanoProduktNaglasniajacy.bsCzyDodanoPrNagl = bs_warstwa_biznesu.bs_BLDodajNaglosnienieDoSklepu(bsNazwaN_str, bsKodN_str, (float)bsCenaN_double);
            if (bsCzyDodanoProduktNaglasniajacy.bsCzyDodanoPrNagl == true)
            {
                bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = true;
                bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

                bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
                bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

                bsTabelaNaglosnienieAdmGrid.Visible = true;
                bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
                bsTabelaNaglosnienieAdmGrid.DataBind();
            }
            else
            {
                bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
                bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
                bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

                bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = true;

                bsTabelaNaglosnienieAdmGrid.Visible = true;
                bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
                bsTabelaNaglosnienieAdmGrid.DataBind();
            }

        }
    }

    protected void bsModyfikujNaglAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsDspPnl.Visible = false;

        bsNaglosnieniePnl.Visible = true;

        int bs_id = bsPolaNaglosnienie.bsIdNagl;
        int bs_naz = bsPolaNaglosnienie.bsNazwaNaglCheck;
        int bs_kod = bsPolaNaglosnienie.bsKodNaglCheck;
        float bs_cena = bsPolaNaglosnienie.bsCenaNagl;
        if (bsIdNaglModTxb.Text == null || bsIdNaglModTxb.Text == "" ||
            bsNazwaNaglModTxb.Text == null || bsNazwaNaglModTxb.Text == "" ||
            bsKodNaglModTxb.Text == null || bsKodNaglModTxb.Text == "" ||
            bsCenaNaglModTxb.Text == null || bsCenaNaglModTxb.Text == "")
        {
            bsWszystkiePolaModNaglMuszaZostacWypelnione.Visible = true;
            bsWpisalesNiepoprawneDaneModNaglPln.Visible = false;

            bsTabelaNaglosnienieAdmGrid.Visible = true;
            bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
            bsTabelaNaglosnienieAdmGrid.DataBind();

        }
        else if (int.TryParse(bsIdNaglModTxb.Text, out bs_id) == false ||
            int.TryParse(bsNazwaNaglModTxb.Text, out bs_naz) == true ||
            int.TryParse(bsKodNaglModTxb.Text, out bs_kod) == true ||
            float.TryParse(bsCenaNaglModTxb.Text, out bs_cena) == false)
        {
            bsWszystkiePolaModNaglMuszaZostacWypelnione.Visible = false;
            bsWpisalesNiepoprawneDaneModNaglPln.Visible = true;

            bsGratulacjeModyfikacjaNaglPowiodlasie.Visible = false;
            bsNiestetyModyfikacjaNaglNiepowiodlasie.Visible = false;

            bsTabelaNaglosnienieAdmGrid.Visible = true;
            bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
            bsTabelaNaglosnienieAdmGrid.DataBind();
        }
        else
        {
            int bs_id_int = Convert.ToInt32(bsIdNaglModTxb.Text);
            string bs_nazwa_str = bsNazwaNaglModTxb.Text;
            string bs_kod_str = bsKodNaglModTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaNaglModTxb.Text);
            bsCzyZmodyfikowanoNaglosnienie.CzyZmodNaglosnienie = bs_warstwa_biznesu.bs_BLModyfikujRekordNaglosnienia(bs_id_int, bs_nazwa_str, bs_kod_str, (float)bs_cena_double);
            if (bsCzyZmodyfikowanoNaglosnienie.CzyZmodNaglosnienie == true)
            {
                bsWszystkiePolaModNaglMuszaZostacWypelnione.Visible = false;
                bsWpisalesNiepoprawneDaneModNaglPln.Visible = false;

                bsGratulacjeModyfikacjaNaglPowiodlasie.Visible = true;
                bsNiestetyModyfikacjaNaglNiepowiodlasie.Visible = false;

                bsTabelaNaglosnienieAdmGrid.Visible = true;
                bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
                bsTabelaNaglosnienieAdmGrid.DataBind();
            }
            else
            {
                bsWszystkiePolaModNaglMuszaZostacWypelnione.Visible = false;
                bsWpisalesNiepoprawneDaneModNaglPln.Visible = false;

                bsGratulacjeModyfikacjaNaglPowiodlasie.Visible = false;
                bsNiestetyModyfikacjaNaglNiepowiodlasie.Visible = true;

                bsTabelaNaglosnienieAdmGrid.Visible = true;
                bsTabelaNaglosnienieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaNaglosnienieAdmGrid();
                bsTabelaNaglosnienieAdmGrid.DataBind();
            }
        }
    }

    protected void bsDodajOpAdmBtn_Click(object sender, EventArgs e)
    {
        bsStudioPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsDspPnl.Visible = false;

        int bs_idOpCheck = bsPolaOprogramowania.bsIdOP;
        int bs_nazwaOpCheck = bsPolaOprogramowania.bsNazwaOpCheck;
        int bs_kodOpCheck = bsPolaOprogramowania.bsKodOpCheck;
        float bs_cenaOpCheck = bsPolaOprogramowania.bsCenaOpCheck;
        bsOprogramowaniePnl.Visible = true;

        if (bsNazwaOpAdmTxb.Text == null || bsNazwaOpAdmTxb.Text == "" ||
            bsKodOpAdmTxb.Text == null || bsKodOpAdmTxb.Text == "" ||
            bsCenaOpAdmTxb.Text == null || bsCenaOpAdmTxb.Text == "")
        {
            bsWymaganePolaOpAdmPnl.Visible = true;
            bsNiepoprawneDaneOpAdmPnl.Visible = false;

            bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl.Visible = false;
            bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl.Visible = false;
            bsTabelaOprogramowanieAdmGrid.Visible = true;
            bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
            bsTabelaOprogramowanieAdmGrid.DataBind();
        }
        else if (int.TryParse(bsNazwaOpAdmTxb.Text, out bs_nazwaOpCheck) == true ||
            int.TryParse(bsKodOpAdmTxb.Text, out bs_kodOpCheck) == true ||
            float.TryParse(bsCenaOpAdmTxb.Text, out bs_cenaOpCheck) == false)
        {
            bsNiepoprawneDaneOpAdmPnl.Visible = true;

            bsWymaganePolaOpAdmPnl.Visible = false;
            bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl.Visible = false;
            bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl.Visible = false;

            bsTabelaOprogramowanieAdmGrid.Visible = true;
            bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
            bsTabelaOprogramowanieAdmGrid.DataBind();
        }
        else
        {
            string bs_nazwaOp_str = bsNazwaOpAdmTxb.Text;
            string bs_kodOp_str = bsKodOpAdmTxb.Text;
            double bs_cenaOp_double = Convert.ToDouble(bsCenaOpAdmTxb.Text);
            bsCzyDodanoOprogramowanie.bsCzyDodanoAdmOp = bs_warstwa_biznesu.bs_BLDodajOprogramowanieDoSklepu(bs_nazwaOp_str, bs_kodOp_str, (float)bs_cenaOp_double);
            if (bsCzyDodanoOprogramowanie.bsCzyDodanoAdmOp == true)
            {
                bsWymaganePolaOpAdmPnl.Visible = false;
                bsNiepoprawneDaneOpAdmPnl.Visible = false;

                bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl.Visible = true;
                bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl.Visible = false;

                bsTabelaOprogramowanieAdmGrid.Visible = true;
                bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
                bsTabelaOprogramowanieAdmGrid.DataBind();
            }
            else
            {
                bsWymaganePolaOpAdmPnl.Visible = false;
                bsNiepoprawneDaneOpAdmPnl.Visible = false;

                bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl.Visible = false;
                bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl.Visible = true;

                bsTabelaOprogramowanieAdmGrid.Visible = true;
                bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
                bsTabelaOprogramowanieAdmGrid.DataBind();
            }


        }
    }

    protected void bsModyfikujOpAdmBtn_Click(object sender, EventArgs e)
    {
        bsStudioPnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsOprogramowaniePnl.Visible = true;
        int bs_idOpCheck = bsPolaOprogramowania.bsIdOP;
        int bs_nazwaOpCheck = bsPolaOprogramowania.bsNazwaOpCheck;
        int bs_kodOpCheck = bsPolaOprogramowania.bsKodOpCheck;
        float bs_cenaOpCheck = bsPolaOprogramowania.bsCenaOpCheck;
        if (bsIdOpModTxb.Text == null || bsIdOpModTxb.Text == "" ||
            bsNazwaOpModTxb.Text == null || bsNazwaOpModTxb.Text == "" ||
            bsKodOpModTxb.Text == null || bsKodOpModTxb.Text == "" ||
            bsCenaOpModTxb.Text == null || bsCenaOpModTxb.Text == "")
        {
            bsWymaganePolaOpModAdmPnl.Visible = true;
            bsPoprawnoscDanychOpAdmPln.Visible = false;

            bsPowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;
            bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;

            bsTabelaOprogramowanieAdmGrid.Visible = true;
            bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
            bsTabelaOprogramowanieAdmGrid.DataBind();
        }
        else if (int.TryParse(bsIdOpModTxb.Text, out bs_idOpCheck) == false ||
            int.TryParse(bsNazwaOpModTxb.Text, out bs_nazwaOpCheck) == true ||
            int.TryParse(bsKodOpModTxb.Text, out bs_kodOpCheck) == true ||
            float.TryParse(bsCenaOpModTxb.Text, out bs_cenaOpCheck) == false)
        {
            bsWymaganePolaOpModAdmPnl.Visible = false;
            bsPoprawnoscDanychOpAdmPln.Visible = true;

            bsPowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;
            bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;

            bsTabelaOprogramowanieAdmGrid.Visible = true;
            bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
            bsTabelaOprogramowanieAdmGrid.DataBind();
        }
        else
        {
            int bsIdOp_int = Convert.ToInt32(bsIdOpModTxb.Text);
            string bsNazwaOp_str = bsNazwaOpModTxb.Text;
            string bsKodOp_str = bsKodOpModTxb.Text;
            double bsCenaOp_double = Convert.ToDouble(bsCenaOpModTxb.Text);
            bsCzyZmodyfikowanoDaneProgramu.bsCzyZmodyfikowanoOpAdm = bs_warstwa_biznesu.bs_BLModyfikujDaneOprogramowania(bsIdOp_int, bsNazwaOp_str, bsKodOp_str, (float)bsCenaOp_double);
            if (bsCzyZmodyfikowanoDaneProgramu.bsCzyZmodyfikowanoOpAdm == true)
            {
                bsPowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = true;
                bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;

                bsWymaganePolaOpModAdmPnl.Visible = false;
                bsPoprawnoscDanychOpAdmPln.Visible = false;

                bsTabelaOprogramowanieAdmGrid.Visible = true;
                bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
                bsTabelaOprogramowanieAdmGrid.DataBind();
            }
            else
            {
                bsPowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = false;
                bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl.Visible = true;

                bsWymaganePolaOpModAdmPnl.Visible = false;
                bsPoprawnoscDanychOpAdmPln.Visible = false;

                bsTabelaOprogramowanieAdmGrid.Visible = true;
                bsTabelaOprogramowanieAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleOprogramowanieAdmGrid();
                bsTabelaOprogramowanieAdmGrid.DataBind();
            }

        }
    }

    protected void bsDodajStDoSklepuBtn_Click(object sender, EventArgs e)
    {
        
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsDspPnl.Visible = false;

        int bs_idCheck = bsPolaStudio.bsIdSt;
        int bs_nazwaCheck = bsPolaStudio.bsNazwaSt;
        int bs_kodCheck = bsPolaStudio.bsKodSt;
        float bs_cenaCheck = bsPolaStudio.bsCenaSt;

        bsStudioPnl.Visible = true;
        if (bsNazwaStAdmTxb.Text == null || bsNazwaStAdmTxb.Text == "" ||
            bsKodStAdmTxb.Text == null || bsKodStAdmTxb.Text == "" ||
            bsCenaStAdmTxb.Text == null || bsCenaStAdmTxb.Text == "")
        {
            bsWymaganePolaStAdmPnl.Visible = true;
            bsNiepoprawneDaneStAdmPnl.Visible = false;

            bsPowodzenieDodaniaStudyjnychDoSklepu.Visible = false;
            bsNiepowodzenieDodaniaStudyjnychDoSklepu.Visible = false;

            bsTabelaStAdmGrid.Visible = true;
            bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
            bsTabelaStAdmGrid.DataBind();
        }
        else if (int.TryParse(bsNazwaStAdmTxb.Text, out bs_nazwaCheck) == true ||
            int.TryParse(bsKodStAdmTxb.Text, out bs_kodCheck) == true ||
            float.TryParse(bsCenaStAdmTxb.Text, out bs_cenaCheck) == false)
        {
            bsNiepoprawneDaneStAdmPnl.Visible = true;
            bsWymaganePolaStAdmPnl.Visible = false;

            bsPowodzenieDodaniaStudyjnychDoSklepu.Visible = false;
            bsNiepowodzenieDodaniaStudyjnychDoSklepu.Visible = false;

            bsTabelaStAdmGrid.Visible = true;
            bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
            bsTabelaStAdmGrid.DataBind();
        }
        else
        {
            string bs_nazwa_str = bsNazwaStAdmTxb.Text;
            string bs_kod_str = bsKodStAdmTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaStAdmTxb.Text);
            bsCzyDodanoStudyjne.bsCzyDodanoSt = bs_warstwa_biznesu.bs_BLDodajStudyjneDoSklepu(bs_nazwa_str,bs_kod_str,(float)bs_cena_double);
            if (bsCzyDodanoStudyjne.bsCzyDodanoSt == true)
            {
                bsPowodzenieDodaniaStudyjnychDoSklepu.Visible = true;
                bsNiepowodzenieDodaniaStudyjnychDoSklepu.Visible = false;

                bsNiepoprawneDaneStAdmPnl.Visible = false;
                bsWymaganePolaStAdmPnl.Visible = false;

                bsTabelaStAdmGrid.Visible = true;
                bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
                bsTabelaStAdmGrid.DataBind();
            }
            else
            {
                bsPowodzenieDodaniaStudyjnychDoSklepu.Visible = false;
                bsNiepowodzenieDodaniaStudyjnychDoSklepu.Visible = true;

                bsNiepoprawneDaneStAdmPnl.Visible = false;
                bsWymaganePolaStAdmPnl.Visible = false;

                bsTabelaStAdmGrid.Visible = true;
                bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
                bsTabelaStAdmGrid.DataBind();
            }
        }
    }

    protected void bsModyfikujStAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsDspPnl.Visible = false;

        int bs_idCheck = bsPolaStudio.bsIdSt;
        int bs_nazwaCheck = bsPolaStudio.bsNazwaSt;
        int bs_kodCheck = bsPolaStudio.bsKodSt;
        float bs_cenaCheck = bsPolaStudio.bsCenaSt;

        bsStudioPnl.Visible = true;

        if (bsIdStModAdmTxb.Text == null || bsIdStModAdmTxb.Text == "" ||
            bsNazwaStModAdmTxb.Text == null || bsNazwaStModAdmTxb.Text == "" ||
            bsKodStModAdmTxb.Text == null || bsKodStModAdmTxb.Text == "" ||
            bsCenaStModAdmTxb.Text == null || bsCenaStModAdmTxb.Text == "")
        {
            bsKomunikatWymaganePolaModAdmPnl.Visible = true;
            bsKomunikatNiepoprawneDaneStModAdmPnl.Visible = false;

            bsPowodzenieModyfikacjiStudioAdmPnl.Visible = false;
            bsNiepowodzenieModyfikacjiStudioAdmPnl.Visible = false;

            bsTabelaStAdmGrid.Visible = true;
            bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
            bsTabelaStAdmGrid.DataBind();
        }
        else if (int.TryParse(bsIdStModAdmTxb.Text, out bs_idCheck) == false ||
            int.TryParse(bsNazwaStModAdmTxb.Text, out bs_nazwaCheck) == true ||
            int.TryParse(bsKodStModAdmTxb.Text, out bs_kodCheck) == true ||
            float.TryParse(bsCenaStModAdmTxb.Text, out bs_cenaCheck) == false)
        {
            bsKomunikatNiepoprawneDaneStModAdmPnl.Visible = true;

            bsKomunikatWymaganePolaModAdmPnl.Visible = false;

            bsPowodzenieModyfikacjiStudioAdmPnl.Visible = false;
            bsNiepowodzenieModyfikacjiStudioAdmPnl.Visible = false;

            bsTabelaStAdmGrid.Visible = true;
            bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
            bsTabelaStAdmGrid.DataBind();
        }
        else
        {
            int bsId_int = Convert.ToInt32(bsIdStModAdmTxb.Text);
            string bsNazwa_str = bsNazwaStModAdmTxb.Text;
            string bsKod_str = bsKodStModAdmTxb.Text;
            double bsCena_double = Convert.ToDouble(bsCenaStModAdmTxb.Text);
            bsCzyZmodyfikowanoSt.bsCzyZmodSt = bs_warstwa_biznesu.bs_BLModyfikujDaneStudio(bsId_int, bsNazwa_str, bsKod_str, (float)bsCena_double);
            if (bsCzyZmodyfikowanoSt.bsCzyZmodSt == true)
            {
                bsPowodzenieModyfikacjiStudioAdmPnl.Visible = true;
                bsNiepowodzenieModyfikacjiStudioAdmPnl.Visible = false;

                bsKomunikatNiepoprawneDaneStModAdmPnl.Visible = false;
                bsKomunikatWymaganePolaModAdmPnl.Visible = false;

                bsTabelaStAdmGrid.Visible = true;
                bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
                bsTabelaStAdmGrid.DataBind();
            }
            else
            {
                bsPowodzenieModyfikacjiStudioAdmPnl.Visible =false;
                bsNiepowodzenieModyfikacjiStudioAdmPnl.Visible = true;

                bsKomunikatNiepoprawneDaneStModAdmPnl.Visible = false;
                bsKomunikatWymaganePolaModAdmPnl.Visible = false;

                bsTabelaStAdmGrid.Visible = true;
                bsTabelaStAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleStAdmGrid();
                bsTabelaStAdmGrid.DataBind();
            }

        }

    }

    protected void bsDodajWypAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWyprzedarzPnl.Visible = true;


        int bs_nazwaCheck = bsPolaWyprzedarzy.bsNazwaWypCheck;
        int bs_kodCheck = bsPolaWyprzedarzy.bsKodWypCheck;
        float bs_cenaCheck = bsPolaWyprzedarzy.bsCenaWypCheck;

        if (bsNazwaWypAdmTxb.Text == null || bsNazwaWypAdmTxb.Text == "" ||
            bsKodWypAdmTxb.Text == null || bsKodWypAdmTxb.Text == "" ||
            bsCenaWypAdmTxb.Text == null || bsCenaWypAdmTxb.Text == "")
        {
            bsKomunikatWymaganePolaWypAdmPnl.Visible = true;
            bsKomunikatNiepoprawneDaneWypAdmPnl.Visible = false;

            bsPowodzenieDodaniaWypAdmPnl.Visible = false;
            bsNiepowodzenieDodaniaWypAdmPnl.Visible = false;

            bsTabelaWyprzedarzyAdmGrid.Visible = true;
            bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
            bsTabelaWyprzedarzyAdmGrid.DataBind();
        }
        else if (int.TryParse(bsNazwaWypAdmTxb.Text, out bs_nazwaCheck) == true ||
            int.TryParse(bsKodWypAdmTxb.Text, out bs_kodCheck) == true ||
            float.TryParse(bsCenaWypAdmTxb.Text, out bs_cenaCheck) == false)
        {
            bsKomunikatNiepoprawneDaneWypAdmPnl.Visible = true;
            bsKomunikatWymaganePolaWypAdmPnl.Visible = false;

            bsPowodzenieDodaniaWypAdmPnl.Visible = false;
            bsNiepowodzenieDodaniaWypAdmPnl.Visible = false;

            bsTabelaWyprzedarzyAdmGrid.Visible = true;
            bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
            bsTabelaWyprzedarzyAdmGrid.DataBind();
        }
        else
        {
            string bs_nazwa_str = bsNazwaWypAdmTxb.Text;
            string bs_kod_str = bsKodWypAdmTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaWypAdmTxb.Text);
            bsCzyDodanoDoWyprzedarzy.bsCzyDodanoWyp = bs_warstwa_biznesu.bs_BLDodajWypDoSklepu(bs_nazwa_str,bs_kod_str,(float)bs_cena_double);
            if (bsCzyDodanoDoWyprzedarzy.bsCzyDodanoWyp == true)
            {
                bsPowodzenieDodaniaWypAdmPnl.Visible = true;
                bsNiepowodzenieDodaniaWypAdmPnl.Visible = false;

                bsKomunikatWymaganePolaWypAdmPnl.Visible = false;
                bsKomunikatNiepoprawneDaneWypAdmPnl.Visible = false;

                bsTabelaWyprzedarzyAdmGrid.Visible = true;
                bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
                bsTabelaWyprzedarzyAdmGrid.DataBind();
            }
            else
            {
                bsPowodzenieDodaniaWypAdmPnl.Visible = false;
                bsNiepowodzenieDodaniaWypAdmPnl.Visible = true;

                bsKomunikatWymaganePolaWypAdmPnl.Visible = false;
                bsKomunikatNiepoprawneDaneWypAdmPnl.Visible = false;

                bsTabelaWyprzedarzyAdmGrid.Visible = true;
                bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
                bsTabelaWyprzedarzyAdmGrid.DataBind();
            }
        }
    }

    protected void Button12_Click(object sender, EventArgs e)
    {

    }

    protected void bsModyfikujWypAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsDspPnl.Visible = false;

        bsWyprzedarzPnl.Visible = true;

        int bs_idCheck = bsPolaWyprzedarzy.bsIdWypCheck;
        int bs_nazwaCheck = bsPolaWyprzedarzy.bsNazwaWypCheck;
        int bs_kodCheck = bsPolaWyprzedarzy.bsKodWypCheck;
        float bs_cenaCheck = bsPolaWyprzedarzy.bsCenaWypCheck;

        if (bsIdWypModAdmTxb.Text == null || bsIdWypModAdmTxb.Text == "" ||
            bsNazwaWypModAdmTxb.Text == null || bsNazwaWypModAdmTxb.Text == "" ||
            bsKodWypModAdmTxb.Text == null || bsKodWypModAdmTxb.Text == "" ||
            bsCenaWypModAdmTxb.Text == null || bsCenaWypModAdmTxb.Text == "")
        {
            bsKomunikatWymaganePolaModWypAdmPnl.Visible = true;
            bsKomunikatNieprawidloweDaneModWypAdmPnl.Visible = false;

            bsPowodzenieModyfikacjiWypAdmPnl.Visible = false;
            bsNiepowodzenieModyfikacjiWypAdmPnl.Visible = false;

            bsTabelaWyprzedarzyAdmGrid.Visible = true;
            bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
            bsTabelaWyprzedarzyAdmGrid.DataBind();


        }
        else if (int.TryParse(bsIdWypModAdmTxb.Text, out bs_idCheck) == false ||
            int.TryParse(bsNazwaWypModAdmTxb.Text, out bs_nazwaCheck) == true ||
            int.TryParse(bsKodWypModAdmTxb.Text, out bs_kodCheck) == true ||
            float.TryParse(bsCenaWypModAdmTxb.Text, out bs_cenaCheck) == false)
        {
            bsKomunikatWymaganePolaModWypAdmPnl.Visible = false;
            bsKomunikatNieprawidloweDaneModWypAdmPnl.Visible = true;

            bsPowodzenieModyfikacjiWypAdmPnl.Visible = false;
            bsNiepowodzenieModyfikacjiWypAdmPnl.Visible = false;

            bsTabelaWyprzedarzyAdmGrid.Visible = true;
            bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
            bsTabelaWyprzedarzyAdmGrid.DataBind();
        }
        else
        {
            int bs_id_int = Convert.ToInt32(bsIdWypModAdmTxb.Text);
            string bs_nazwa_str = bsNazwaWypModAdmTxb.Text;
            string bs_kod_str = bsKodWypModAdmTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaWypModAdmTxb.Text);
            bsCzyZmodyfikowanoWyprzedarz.bsCzyZmodWyp = bs_warstwa_biznesu.bs_BLModyfikujRekordWyp(bs_id_int, bs_nazwa_str, bs_kod_str, (float)bs_cena_double);
            if (bsCzyZmodyfikowanoWyprzedarz.bsCzyZmodWyp == true)
            {
                bsPowodzenieModyfikacjiWypAdmPnl.Visible = true;
                bsNiepowodzenieModyfikacjiWypAdmPnl.Visible = false;

                bsKomunikatWymaganePolaModWypAdmPnl.Visible = false;
                bsKomunikatNieprawidloweDaneModWypAdmPnl.Visible = false;

                bsTabelaWyprzedarzyAdmGrid.Visible = true;
                bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
                bsTabelaWyprzedarzyAdmGrid.DataBind();
            }
            else
            {
                bsPowodzenieModyfikacjiWypAdmPnl.Visible = false;
                bsNiepowodzenieModyfikacjiWypAdmPnl.Visible = true;

                bsKomunikatWymaganePolaModWypAdmPnl.Visible = false;
                bsKomunikatNieprawidloweDaneModWypAdmPnl.Visible = false;

                bsTabelaWyprzedarzyAdmGrid.Visible = true;
                bsTabelaWyprzedarzyAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaWypAdmGrid();
                bsTabelaWyprzedarzyAdmGrid.DataBind();
            }
        }
    }

    protected void bsDodajDspAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;

        bsDspPnl.Visible = true;


        int bs_idDspCheck = bsPolaDsp.bsIdDsp;
        int bs_nazwaDspCheck = bsPolaDsp.bsNazwaDsp;
        int bs_kodDspCheck = bsPolaDsp.bsKodDsp;
        float bs_cenaDspCheck = bsPolaDsp.bsCenaDsp;
        if (bsNazwaDspAdmTxb.Text == null || bsNazwaDspAdmTxb.Text == "" ||
            bsKodDspAdmTxb.Text == null || bsKodDspAdmTxb.Text == "" ||
            bsCenaDspAdmTxb.Text == null || bsCenaDspAdmTxb.Text == "")
        {
            bsWymaganePolaDspAdmPnl.Visible = true;
            bsNiepoprawneDaneDspAdmPnl.Visible = false;

            bsPowodzenieDodaniaDspAdmPnl.Visible = false;
            bsNiepowodzenieDodaniaDspAdmPnl.Visible = false;

            bsTabelaDspAdmGrid.Visible = true;
            bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
            bsTabelaDspAdmGrid.DataBind();
        }
        else if (int.TryParse(bsNazwaDspAdmTxb.Text, out bs_nazwaDspCheck) == true ||
            int.TryParse(bsKodDspAdmTxb.Text, out bs_kodDspCheck) == true ||
            float.TryParse(bsCenaDspAdmTxb.Text, out bs_cenaDspCheck) == false)
        {
            bsWymaganePolaDspAdmPnl.Visible = false;
            bsNiepoprawneDaneDspAdmPnl.Visible = true;

            bsPowodzenieDodaniaDspAdmPnl.Visible = false;
            bsNiepowodzenieDodaniaDspAdmPnl.Visible = false;

            bsTabelaDspAdmGrid.Visible = true;
            bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
            bsTabelaDspAdmGrid.DataBind();
        }
        else
        {
            string bs_nazwa_str = bsNazwaDspAdmTxb.Text;
            string bs_kod_str = bsKodDspAdmTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaDspAdmTxb.Text);
            bsCzyDodanoDsp.bsCzyDodanoProduktDsp = bs_warstwa_biznesu.bs_BLDodajDspDoSklepu(bs_nazwa_str, bs_kod_str, (float)bs_cena_double);
            if (bsCzyDodanoDsp.bsCzyDodanoProduktDsp == true)
            {
                bsWymaganePolaDspAdmPnl.Visible = false;
                bsNiepoprawneDaneDspAdmPnl.Visible = false;

                bsPowodzenieDodaniaDspAdmPnl.Visible = true;
                bsNiepowodzenieDodaniaDspAdmPnl.Visible = false;

                bsTabelaDspAdmGrid.Visible = true;
                bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
                bsTabelaDspAdmGrid.DataBind();
            }
            else
            {
                bsWymaganePolaDspAdmPnl.Visible = false;
                bsNiepoprawneDaneDspAdmPnl.Visible = false;

                bsPowodzenieDodaniaDspAdmPnl.Visible = false;
                bsNiepowodzenieDodaniaDspAdmPnl.Visible = true;

                bsTabelaDspAdmGrid.Visible = true;
                bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
                bsTabelaDspAdmGrid.DataBind();
            }
        }

    }

    protected void bsModyfikujDspBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;


        bsDspPnl.Visible = true;
        int bs_idCheck = bsPolaDsp.bsIdDsp;
        int bs_nazwaCheck = bsPolaDsp.bsNazwaDsp;
        int bs_kodCheck = bsPolaDsp.bsKodDsp;
        float bs_cenaCheck = bsPolaDsp.bsCenaDsp;
        if (bsIdDspModAdmTxb.Text == null || bsIdDspModAdmTxb.Text == "" ||
            bsNazwaDspModAdmTxb.Text == null || bsNazwaDspModAdmTxb.Text == "" ||
            bsKodDspModAdmTxb.Text == null || bsKodDspModAdmTxb.Text == "" ||
            bsCenaDspModAdmTxb.Text == null || bsCenaDspModAdmTxb.Text == "")
        {
            bsKomunikatWymaganePolaDspModAdmPnl.Visible = true;
            bsKomunikatNiepoprawneDaneDspModAdmPnl.Visible = false;
            bsPowodzenieModyfikacjiDspPnl.Visible = false;
            bsNiepowodzenieModyfikacjiDspPnl.Visible = false;

            bsTabelaDspAdmGrid.Visible = true;
            bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
            bsTabelaDspAdmGrid.DataBind();
        }
        else if (int.TryParse(bsIdDspModAdmTxb.Text, out bs_idCheck) == false ||
            int.TryParse(bsNazwaDspModAdmTxb.Text, out bs_nazwaCheck) == true ||
            int.TryParse(bsKodDspModAdmTxb.Text, out bs_kodCheck) == true ||
            float.TryParse(bsCenaDspModAdmTxb.Text, out bs_cenaCheck) == false)
        {
            bsKomunikatWymaganePolaDspModAdmPnl.Visible = false;
            bsKomunikatNiepoprawneDaneDspModAdmPnl.Visible = true;
            bsPowodzenieModyfikacjiDspPnl.Visible = false;
            bsNiepowodzenieModyfikacjiDspPnl.Visible = false;

            bsTabelaDspAdmGrid.Visible = true;
            bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
            bsTabelaDspAdmGrid.DataBind();
        }
        else
        {
            int bs_id_int = Convert.ToInt32(bsIdDspModAdmTxb.Text);
            string bs_nazwa_str = bsNazwaDspModAdmTxb.Text;
            string bs_kod_str = bsKodDspModAdmTxb.Text;
            double bs_cena_double = Convert.ToDouble(bsCenaDspModAdmTxb.Text);
            bsCzyZmodyfikowanoDsp.bsCzyZmodyfDsp = bs_warstwa_biznesu.bs_BLModyfikujeDsp(bs_id_int, bs_nazwa_str, bs_kod_str, (float)bs_cena_double);
            if (bsCzyZmodyfikowanoDsp.bsCzyZmodyfDsp == true)
            {
                bsKomunikatWymaganePolaDspModAdmPnl.Visible = false;
                bsKomunikatNiepoprawneDaneDspModAdmPnl.Visible = false;
                bsPowodzenieModyfikacjiDspPnl.Visible = true;
                bsNiepowodzenieModyfikacjiDspPnl.Visible = false;

                bsTabelaDspAdmGrid.Visible = true;
                bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
                bsTabelaDspAdmGrid.DataBind();
            }
            else
            {
                bsKomunikatWymaganePolaDspModAdmPnl.Visible = false;
                bsKomunikatNiepoprawneDaneDspModAdmPnl.Visible = false;
                bsPowodzenieModyfikacjiDspPnl.Visible = false;
                bsNiepowodzenieModyfikacjiDspPnl.Visible = true;

                bsTabelaDspAdmGrid.Visible = true;
                bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
                bsTabelaDspAdmGrid.DataBind();
            }
        }
       
        

    }

    protected void bsDspAdmBtn_Click(object sender, EventArgs e)
    {
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsWyprzedarzPnl.Visible = false;

        bsDspPnl.Visible = true;

        bsWymaganePolaAkcesoriaPnl.Visible = false;
        
        bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl.Visible = false;
        bsGratulacjeDodanoAkcesoriumDoSklepuPnl.Visible = false;
        bsNiestetyNieDodanoAkcesoriumDoSklepuPnl.Visible = false;

        bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl.Visible = false;
        
        bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl.Visible = false;
        bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl.Visible = false;
        bsTabelaAdministracyjnaAkcesoriowGrid.Visible = false;
        bsWprowadzoneDaneNieSaPoprawneModInstrPnl.Visible = false;

        bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie.Visible = false;
        bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie.Visible = false;

        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGratulujeDodanoNaglosnienieDoSklepuPnl.Visible = false;
        bsNiestetyNiedodanoNaglosnieniaDoSklepu.Visible = false;

        bsWypelnijWszystkiePolaNaglosnieniePnl.Visible = false;
        bsWpisalesNiepoprawneDaneDodNaglPnl.Visible = false;

        bsGorneMenuAdministracjaPnl.Visible = true;

        bsTabelaDspAdmGrid.Visible = true;
        bsTabelaDspAdmGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabelaDspAdmGrid();
        bsTabelaDspAdmGrid.DataBind();
        

    }
}