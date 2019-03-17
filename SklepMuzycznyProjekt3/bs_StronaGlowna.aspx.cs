using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_StronaGlowna : System.Web.UI.Page
{
    private bsBusinesLayer bs_warstwa_biznesowa = new bsBusinesLayer();
    public bsKlasaUsera bs_obiekt_usera = new bsKlasaUsera();
   
    private string ladm, hadm;
    protected void Page_Load(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = true;
        bsTabelaAkcesoriowGrid.Visible = false;
        if (bsKlasaUsera.bsLoginUsera != null && bsKlasaUsera.bsHasloUsera != null && bsKlasaUsera.bsLoginUsera!="Nikt")
        {
            bsKoszykBtn.Enabled = true;
            bsLoginTxb.Enabled = false;
            bsHasloTxb.Enabled = false;

            bsLogowaniePnl.Visible = true;
            bsWylogujBtn.Visible = true;
            bsKomunikatJestesZalogowany.Visible = true;
            bsRejestrowanieBtn.Enabled = false;

            bsLoginTxb.Enabled = false;
            bsHasloTxb.Enabled = false;
            bsZalogujBtn.Enabled = false;
            
            bsGridPokazujacyZalogowanegoUsera.Visible = true;
            bsGridPokazujacyZalogowanegoUsera.DataSource = bs_warstwa_biznesowa.bs_BalWyswietlLoginZalogowanegoUsera(bsKlasaUsera.bsLoginUsera, bsKlasaUsera.bsHasloUsera);
            bsGridPokazujacyZalogowanegoUsera.DataBind();

            bsCzolowaZyczeniaPnl.Visible = false;
            bsWyprzedarzPln.Visible = false;
            bsInstrumentyPnl.Visible = false;
            bsNaglosnieniePnl.Visible = false;
            bsAkcesoriaPnl.Visible = false;
            bsOprogramowaniePnl.Visible = false;
            bsStudioPnl.Visible = false;
            bsProcesoryPnl.Visible = false;
            bsONasPnl.Visible = false;
            bsKontaktPnl.Visible = false;
            bsFaqPnl.Visible = false;
            bsTransportPnl.Visible = false;
            bsPlatnosciPnl.Visible = false;
            bsTaxFreePnl.Visible = false;
            bsRejestrowaniePnl.Visible = false;
            bsKomunikatWymaganePolaLogowania.Visible = false;
            bsKomunikatCzyIstniejeTakiUser.Visible = false;
            
            bsKomunikatNieJestesZalogowany.Visible = false;
            
            bsFormaLogowaniaPnl.Visible = false;
            bsFormalarzRejestracjiPnl.Visible = false;

            bsKomunikatRejestracjiWymaganePola.Visible = false;
            bsKomunikatRejestracjiPoprawnoscDanych.Visible = false;
            bsKomunikatPowodzeniaUtworzeniaKontaUsera.Visible = false;
            bsKomunikatNiepowodzeniaUtworzeniaKonta.Visible = false;


            bsRejestrujBtn.Visible = false;
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
            bsFormularzLogowaniaAdminaPnl.Visible = false;
            bsAdmPowodzeniePolaPln.Visible = false;
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;

            bsLogowanieAdminaPnl.Visible = false;
            bsKomikatOPoprawnosciDanych.Visible = false;

            bsTabelaAkcesoriowGrid.Visible = false;
            bsGratulacjeDodanoAkcesoriumDoKoszyka.Visible = false;
            bsPrzykroNamNieDodanoProduktuDoKoszyka.Visible = false;
            bsTabelaNaglosnienieGrid.Visible = false;
            bsOprogramowanieGrid.Visible = false;

            bsTabelaStudioGrid.Visible = false;
            bsTabelaWyprzedarzyGrid.Visible = false;
            bsTabelaDspGrid.Visible = false;

            bsPowodzenieDodaniaDoKoszykaWK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaWK.Visible = false;

            bsPowodzenieDodaniaDoKoszykaIKPnl.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaIKPnl.Visible = false;

            bsPowodzenieDodaniaDoKoszykaNK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaNK.Visible = false;

            bsPowodzenieOKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieOKDodaniaDoKoszykaPnl.Visible = false;

            bsPowodzenieSKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieSKDodaniaDoKoszykaPnl.Visible = false;

            bsPowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;
            bsNiepowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;

        }
        else
        {
            bsKlasaUsera.bsLoginUsera = "Nikt";
            bsGridPokazujacyZalogowanegoUsera.Visible = false;
            bsLoginTxb.Enabled = true;
            bsHasloTxb.Enabled = true;
            bsZalogujBtn.Enabled = true;
            

            bsCzolowaZyczeniaPnl.Visible = true;
            bsWyprzedarzPln.Visible = false;
            bsInstrumentyPnl.Visible = false;
            bsNaglosnieniePnl.Visible = false;
            bsAkcesoriaPnl.Visible = false;
            bsOprogramowaniePnl.Visible = false;
            bsStudioPnl.Visible = false;
            bsProcesoryPnl.Visible = false;
            bsONasPnl.Visible = false;
            bsKontaktPnl.Visible = false;
            bsFaqPnl.Visible = false;
            bsTransportPnl.Visible = false;
            bsPlatnosciPnl.Visible = false;
            bsTaxFreePnl.Visible = false;
            bsLogowaniePnl.Visible = false;
            bsRejestrowaniePnl.Visible = false;
            bsKomunikatWymaganePolaLogowania.Visible = false;
            bsKomunikatCzyIstniejeTakiUser.Visible = false;
            bsKomunikatJestesZalogowany.Visible = false;
            bsKomunikatNieJestesZalogowany.Visible = false;
            bsWylogujBtn.Visible = false;
            bsFormaLogowaniaPnl.Visible = false;
            bsFormalarzRejestracjiPnl.Visible = false;

            bsKomunikatRejestracjiWymaganePola.Visible = false;
            bsKomunikatRejestracjiPoprawnoscDanych.Visible = false;
            bsKomunikatPowodzeniaUtworzeniaKontaUsera.Visible = false;
            bsKomunikatNiepowodzeniaUtworzeniaKonta.Visible = false;

            
            bsRejestrujBtn.Visible = false;
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
            bsFormularzLogowaniaAdminaPnl.Visible = false;
            bsAdmPowodzeniePolaPln.Visible = false;
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;

            bsLogowanieAdminaPnl.Visible = false;
            bsKomikatOPoprawnosciDanych.Visible = false;
            bsKomunikatBrakTakiegoUseraLbl.Visible = false;

            bsTabelaAkcesoriowGrid.Visible = false;
            bsGratulacjeDodanoAkcesoriumDoKoszyka.Visible = false;
            bsPrzykroNamNieDodanoProduktuDoKoszyka.Visible = false;
            bsTabelaInstrumentowGrid.Visible = false;
            bsTabelaNaglosnienieGrid.Visible = false;
            bsOprogramowanieGrid.Visible = false;

            bsTabelaStudioGrid.Visible = false;

            bsTabelaWyprzedarzyGrid.Visible = false;
            bsTabelaDspGrid.Visible = false;

            bsPowodzenieDodaniaDoKoszykaWK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaWK.Visible = false;

            bsPowodzenieDodaniaDoKoszykaIKPnl.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaIKPnl.Visible = false;

            bsPowodzenieDodaniaDoKoszykaNK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaNK.Visible = false;

            bsPowodzenieOKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieOKDodaniaDoKoszykaPnl.Visible = false;

            bsPowodzenieSKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieSKDodaniaDoKoszykaPnl.Visible = false;

            bsPowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;
            bsNiepowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;

        }
    }
    
    protected void bsWyprzedarzBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = true;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaNaglosnienieGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaWyprzedarzyGrid.Visible = true;
        bsTabelaWyprzedarzyGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaWypGrid();
        bsTabelaWyprzedarzyGrid.DataBind();
    }

    protected void bsInstrumentyBtn_Click(object sender, EventArgs e)
    {

        bsInstrumentyPnl.Visible = true;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaNaglosnienieGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;


        bsTabelaInstrumentowGrid.Visible = true;
        bsTabelaInstrumentowGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleInstrumentowGrid();
        bsTabelaInstrumentowGrid.DataBind();
    }

    protected void bsNaglosnienieBtn_Click(object sender, EventArgs e)
    {
        bsOprogramowaniePnl.Visible = false;
        bsNaglosnieniePnl.Visible = true;
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;


        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaNaglosnienieGrid.Visible = true;
        bsTabelaNaglosnienieGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaNaglosnienieGrid();
        bsTabelaNaglosnienieGrid.DataBind();
    }

    protected void bsAkcesoriaBtn_Click(object sender, EventArgs e)
    {
        bsOprogramowaniePnl.Visible = false;

        bsAkcesoriaPnl.Visible = true;

        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaAkcesoriowGrid.Visible = true;
        bsTabelaAkcesoriowGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleAkcesoriowGrid();
        bsTabelaAkcesoriowGrid.DataBind();

        bsTabelaInstrumentowGrid.Visible = false;


    }

    protected void bsOprogramowanieBtn_Click(object sender, EventArgs e)
    {
        bsOprogramowaniePnl.Visible = true;

        bsAkcesoriaPnl.Visible =false;
        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsOprogramowanieGrid.Visible = true;
        bsOprogramowanieGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleOprogramowanieGrid();
        bsOprogramowanieGrid.DataBind();

    }

    protected void bsStudioBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;

        bsStudioPnl.Visible = true;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaStudioGrid.Visible = true;
        bsTabelaStudioGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleStGrid();
        bsTabelaStudioGrid.DataBind();
    }

    protected void bsAdministratorBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = true;
        bsFormularzLogowaniaAdminaPnl.Visible = true;
        bsTabelaInstrumentowGrid.Visible = false;
        
    }

    protected void bsProcesoryBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;


        bsProcesoryPnl.Visible = true;
        bsTabelaDspGrid.Visible = false;

        bsTabelaDspGrid.Visible = true;
        bsTabelaDspGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaDspGrid();
        bsTabelaDspGrid.DataBind();
    }

    protected void bsONasBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsONasPnl.Visible = true;
    }

    protected void bsKontaktBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsKontaktPnl.Visible = true;
    }

    protected void bsFAQBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsFaqPnl.Visible = true;
    }

    protected void bsRatyPayUBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://www.payu.pl/payu-raty-dla-Ciebie");
    }

    protected void bsTransportBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTransportPnl.Visible = true;
    }

    protected void bsPlatnosciBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsPlatnosciPnl.Visible = true;
    }

    protected void bsTaxFreeBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTaxFreePnl.Visible = true;
    }

    protected void bsLogowanieBtn_Click(object sender, EventArgs e)
    {
        
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;


        bsFormalarzRejestracjiPnl.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        
        if (bsKlasaUsera.bsLoginUsera != null && bsKlasaUsera.bsHasloUsera != null)
        {
            bsKomunikatJestesZalogowany.Visible = true;
            bsWylogujBtn.Visible = true;

            bsKomunikatNieJestesZalogowany.Visible = false;
            bsRejestrowanieBtn.Enabled = false;
            bsFormaLogowaniaPnl.Visible = false;
            bsTabelaAkcesoriowGrid.Visible = false;

        }
        else if (bsKlasaUsera.bsLoginUsera == null && bsKlasaUsera.bsHasloUsera == null)
        {
            bsKomunikatNieJestesZalogowany.Visible = true;
            bsFormaLogowaniaPnl.Visible = true;
            bsLogowaniePnl.Visible = true;


            bsKomunikatJestesZalogowany.Visible = false;
            bsRejestrowanieBtn.Enabled = true;
            bsWylogujBtn.Visible = false;
            bsTabelaAkcesoriowGrid.Visible = false;


        }

        
    }

    protected void bsRejestrowanieBtn_Click(object sender, EventArgs e)
    {

        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;

        bsLogowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsRejestrowaniePnl.Visible = true;
        bsFormalarzRejestracjiPnl.Visible = true;
        bsRejestrujBtn.Visible = true;
        
        
    }

    protected void bsZalogujBtn_Click(object sender, EventArgs e)
    {
        
        string bsloginstr = bsLoginTxb.Text;
        string bshaslostr = bsHasloTxb.Text;
        if (bsLoginTxb.Text == null || bsLoginTxb.Text == ""
            || bsloginstr == null || bsloginstr == "" ||
            bsHasloTxb.Text == null || bsHasloTxb.Text == "" ||
            bshaslostr == null || bshaslostr == "")
        {
            bsKlasaUsera.bsLoginUsera = "Nikt";
            bsLogowaniePnl.Visible = true;
            bsLoginTxb.Visible = true;
            bsHasloTxb.Visible = true;

            
            bsKomunikatWymaganePolaLogowania.Visible = true;

            bsCzolowaZyczeniaPnl.Visible = false;
            bsWyprzedarzPln.Visible = false;
            bsInstrumentyPnl.Visible = false;
            bsNaglosnieniePnl.Visible = false;
            bsAkcesoriaPnl.Visible = false;
            bsOprogramowaniePnl.Visible = false;
            bsStudioPnl.Visible = false;
            bsProcesoryPnl.Visible = false;
            bsONasPnl.Visible = false;
            bsKontaktPnl.Visible = false;
            bsFaqPnl.Visible = false;
            bsTransportPnl.Visible = false;
            bsPlatnosciPnl.Visible = false;
            bsTaxFreePnl.Visible = false;
            bsKomunikatCzyIstniejeTakiUser.Visible = false;
            bsRejestrowaniePnl.Visible = false;
            bsWylogujBtn.Visible = false;
            bsGridPokazujacyZalogowanegoUsera.Visible = false;
            bsAdmPowodzeniePolaPln.Visible = false;
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
            bsTabelaAkcesoriowGrid.Visible = false;
            bsTabelaInstrumentowGrid.Visible = false;
            bsTabelaDspGrid.Visible = false;

        }
        else
        {
            
            bsKlasaUsera.bsLoginUsera = bs_warstwa_biznesowa.bsBLMetodaZwracajacaLoginzTabeliUsers(bsloginstr,bshaslostr);
            bsKlasaUsera.bsHasloUsera = bs_warstwa_biznesowa.bsBLMetodaZwracajacaHaslozTabeliUsers(bsloginstr,bshaslostr);
            
            if (bsKlasaUsera.bsLoginUsera == null || bsKlasaUsera.bsHasloUsera == null)
            {
                bsKomunikatCzyIstniejeTakiUser.Visible = true;
                bsKomunikatBrakTakiegoUseraLbl.Text = bsTrescErrorow.brakTakiegoUsera;
                bsKomunikatBrakTakiegoUseraLbl.Visible = true;

                bsLoginTxb.Visible = true;
                bsHasloTxb.Visible = true;
                bsLogowaniePnl.Visible = true;
               
                bsZalogujBtn.Visible = true;
                bsWylogujBtn.Visible = false;

                bsKomunikatWymaganePolaLogowania.Visible = false;
                bsKomunikatWymaganePolaLogowania.Visible = false;
                bsCzolowaZyczeniaPnl.Visible = false;
                bsWyprzedarzPln.Visible = false;
                bsInstrumentyPnl.Visible = false;
                bsNaglosnieniePnl.Visible = false;
                bsAkcesoriaPnl.Visible = false;
                bsOprogramowaniePnl.Visible = false;
                bsStudioPnl.Visible = false;
                bsProcesoryPnl.Visible = false;
                bsONasPnl.Visible = false;
                bsKontaktPnl.Visible = false;
                bsFaqPnl.Visible = false;
                bsTransportPnl.Visible = false;
                bsPlatnosciPnl.Visible = false;
                bsTaxFreePnl.Visible = false;
                bsRejestrowaniePnl.Visible = false;
                bsWylogujBtn.Visible = false;
                bsGridPokazujacyZalogowanegoUsera.Visible = false;
                bsAdmPowodzeniePolaPln.Visible = false;
                bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
                bsTabelaAkcesoriowGrid.Visible = false;
                bsTabelaInstrumentowGrid.Visible = false;
            }
            else
            {
                //***********************************************************************************
                //************************************************************************************
                bsKomunikatBrakTakiegoUseraLbl.Visible = false;
                bsLogowaniePnl.Visible = true;
                bsRejestrowanieBtn.Enabled = false;
               
                bsKoszykBtn.Enabled = true;
                bsLoginTxb.Enabled = false;
                bsHasloTxb.Enabled = false;
                bsZalogujBtn.Enabled = false;
                bsWylogujBtn.Visible = true;
                bsGridPokazujacyZalogowanegoUsera.Visible = true;
                bsGridPokazujacyZalogowanegoUsera.DataSource = bs_warstwa_biznesowa.bs_BalWyswietlLoginZalogowanegoUsera(bsloginstr,bshaslostr);
                bsGridPokazujacyZalogowanegoUsera.DataBind();


                bsKomunikatWymaganePolaLogowania.Visible = false;
                bsKomunikatWymaganePolaLogowania.Visible = false;
                bsCzolowaZyczeniaPnl.Visible = false;
                bsWyprzedarzPln.Visible = false;
                bsInstrumentyPnl.Visible = false;
                bsNaglosnieniePnl.Visible = false;
                bsAkcesoriaPnl.Visible = false;
                bsOprogramowaniePnl.Visible = false;
                bsStudioPnl.Visible = false;
                bsProcesoryPnl.Visible = false;
                bsONasPnl.Visible = false;
                bsKontaktPnl.Visible = false;
                bsFaqPnl.Visible = false;
                bsTransportPnl.Visible = false;
                bsPlatnosciPnl.Visible = false;
                bsTaxFreePnl.Visible = false;
                bsRejestrowaniePnl.Visible = false;
                bsAdmPowodzeniePolaPln.Visible = false;
                bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
                bsTabelaAkcesoriowGrid.Visible = false;
                bsTabelaInstrumentowGrid.Visible = false;
            }

        }
    }

    protected void bsWylogujBtn_Click(object sender, EventArgs e)
    {
        bsLoginTxb.Text = "";
        bsHasloTxb.Text = "";
        bsKlasaUsera.bsLoginUsera = null;
        bsKlasaUsera.bsHasloUsera = null;
       

        bsLogowaniePnl.Visible = true;
        bsRejestrowanieBtn.Enabled = true;
        bsLoginTxb.Enabled = true;
        bsHasloTxb.Enabled = true;
       
        bsZalogujBtn.Visible = true;
        bsZalogujBtn.Enabled = true;
        bsWylogujBtn.Visible = false;
        bsGridPokazujacyZalogowanegoUsera.Visible = false;


        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatJestesZalogowany.Visible = false;
        bsKomunikatNieJestesZalogowany.Visible = true;

        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;

    }

    protected void bsRejestrujBtn_Click(object sender, EventArgs e)
    {
        bsCzolowaZyczeniaPnl.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        string bs_login_rej_string, bs_haslo_rej_string;
        bool czy_dodano_rekord;
        int bs_login_rej_int, bs_haslo_rej_int;
        if (bsLoginRejTxb.Text == null || bsLoginRejTxb.Text == "" || bsHasloRejTxb.Text == null || bsHasloRejTxb.Text == "")
        {
            bsRejestrowaniePnl.Visible = true;
            bsRejestrujBtn.Visible = true;

            bsKomunikatRejestracjiWymaganePola.Visible = true;
            bsKomunikatRejestracjiPoprawnoscDanych.Visible = false;
            bsKomunikatPowodzeniaUtworzeniaKontaUsera.Visible = false;


            bsKomunikatNiepowodzeniaUtworzeniaKonta.Visible = true;
            bsFormalarzRejestracjiPnl.Visible = true;
            
            bsTabelaAkcesoriowGrid.Visible = false;
        }
        else if (int.TryParse(bsLoginRejTxb.Text, out bs_login_rej_int) == true || int.TryParse(bsHasloRejTxb.Text, out bs_haslo_rej_int) == true)
        {
            bsRejestrowaniePnl.Visible = true;
            bsRejestrujBtn.Visible = true;
            bsKomunikatRejestracjiWymaganePola.Visible = false;
            bsKomunikatRejestracjiPoprawnoscDanych.Visible = true;
            bsKomunikatPowodzeniaUtworzeniaKontaUsera.Visible = false;
            bsKomunikatNiepowodzeniaUtworzeniaKonta.Visible = true;
            bsFormalarzRejestracjiPnl.Visible = true;
            

            bsTabelaAkcesoriowGrid.Visible = false;

        }
        else
        {
            bs_login_rej_string = bsLoginRejTxb.Text;
            bs_haslo_rej_string = bsHasloRejTxb.Text;
            czy_dodano_rekord = bs_warstwa_biznesowa.bs_BLDodajRekord(bs_login_rej_string,bs_haslo_rej_string);
            bsRejestrowaniePnl.Visible = true;
            bsFormalarzRejestracjiPnl.Visible = false;
            
            bsKomunikatRejestracjiWymaganePola.Visible = false;
            bsKomunikatRejestracjiPoprawnoscDanych.Visible = false;
            bsKomunikatNiepowodzeniaUtworzeniaKonta.Visible = false;
            bsKomunikatPowodzeniaUtworzeniaKontaUsera.Visible = true;
            bsRejestrujBtn.Visible = false;
            bsTabelaAkcesoriowGrid.Visible = false;
        }
    }

    protected void bsZalogujAdminaBtn_Click(object sender, EventArgs e)
    {

        bsCzolowaZyczeniaPnl.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        int bs_login_admina_int, bs_haslo_admina_int;
        string bs_login_admina_string = bsAdminLoginTxb.Text;
        string bs_haslo_admina_string = bsAdminHasloTxb.Text;
        if (bs_login_admina_string == "" || bs_haslo_admina_string == "")
        {
            bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = true;
            bsLogowanieAdminaPnl.Visible = true;
            bsFormularzLogowaniaAdminaPnl.Visible = true;
            bsKomikatOPoprawnosciDanych.Visible = false;
            bsCzolowaZyczeniaPnl.Visible = false;
            bsTabelaAkcesoriowGrid.Visible = false;
        }
        else
        {
           bsAdministrator.bswynikZapytania = bs_warstwa_biznesowa.bsBLMetodaZwracajacaWartoscStringZKomorki(bs_login_admina_string,bs_haslo_admina_string);
            
            if (bsAdministrator.bswynikZapytania == null)
            {
                bsLogowanieAdminaPnl.Visible = true;
                bsKomikatOPoprawnosciDanych.Visible = true;

                bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false; 

                bsFormularzLogowaniaAdminaPnl.Visible = true;
                
                bsCzolowaZyczeniaPnl.Visible = false;

                bsTabelaAkcesoriowGrid.Visible = false;
            }
            else if (int.TryParse(bsAdminLoginTxb.Text, out bs_login_admina_int) == true && int.TryParse(bsAdminHasloTxb.Text, out bs_haslo_admina_int) == true)
            {
                bsKomikatOPoprawnosciDanych.Visible = true;
                bsLogowanieAdminaPnl.Visible = true;
                bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
                bsFormularzLogowaniaAdminaPnl.Visible = true;
               
                
                bsCzolowaZyczeniaPnl.Visible = false;
                bsTabelaAkcesoriowGrid.Visible = false;
            }
            else if (bsAdministrator.bswynikZapytania!=null)
            {
               
                
               
                Response.Redirect("bs_Administratorzy.aspx");
               
                
                
            }
        }
    }

    protected void bsKoszykBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("bsStronaKoszyk.aspx");
    }

    protected void bsTabelaAkcesoriowGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_ilosc = 1;

        bsTabelaInstrumentowGrid.Visible = false;
        int bs_wybranyIndex = bsTabelaAkcesoriowGrid.SelectedIndex;
        bsPolaAkcesoriaKoszyk.bsNazwa = bsTabelaAkcesoriowGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaAkcesoriaKoszyk.bsKod = bsTabelaAkcesoriowGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_c = bsPolaAkcesoriaKoszyk.bsCena;
        
        if (float.TryParse(bsTabelaAkcesoriowGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_c) == true)
            bsPolaAkcesoriaKoszyk.bsCena = bs_c;
        
            bsCzyDodanoAkcesoriaDoKoszyka.bsCzyDodanoAkcDoKoszyka = bs_warstwa_biznesowa.bs_BLDodajAkcesoriaDoKoszyka(bsPolaAkcesoriaKoszyk.bsNazwa, bsPolaAkcesoriaKoszyk.bsKod, (float)bsPolaAkcesoriaKoszyk.bsCena, bsKlasaUsera.bsLoginUsera);
            if (bsCzyDodanoAkcesoriaDoKoszyka.bsCzyDodanoAkcDoKoszyka == true)
            {
                bsGratulacjeDodanoAkcesoriumDoKoszyka.Visible = true;
                bsPrzykroNamNieDodanoProduktuDoKoszyka.Visible = false;
            }
            else
            {
                bsGratulacjeDodanoAkcesoriumDoKoszyka.Visible = false;
                bsPrzykroNamNieDodanoProduktuDoKoszyka.Visible = true;
            }

        bsOprogramowaniePnl.Visible = false;

        bsAkcesoriaPnl.Visible = true;

        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaAkcesoriowGrid.Visible = true;
        bsTabelaAkcesoriowGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleAkcesoriowGrid();
        bsTabelaAkcesoriowGrid.DataBind();

        bsTabelaInstrumentowGrid.Visible = false;


        bool bs_czy_dodano_akcesoria_do_koszyka;
        
    }

    protected void bsTabelaWyprzedarzyGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsTabelaWyprzedarzyGrid.SelectedIndex;
        bsPolaWK.bsNazwaWK = bsTabelaWyprzedarzyGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaWK.bsKodWK = bsTabelaWyprzedarzyGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaWK.bsCenaWK;
        if (float.TryParse(bsTabelaWyprzedarzyGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena) == true)
            bsPolaWK.bsCenaWK = bs_cena;
        bsCzyDodanoDoWyprzedarzyKoszyk.bsCzyDodanoDoWypKoszyk = bs_warstwa_biznesowa.bs_BLDodajProduktWyprzedarzowyDoKoszyka(bsPolaWK.bsNazwaWK, bsPolaWK.bsKodWK, bsPolaWK.bsCenaWK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoDoWyprzedarzyKoszyk.bsCzyDodanoDoWypKoszyk == true)
        {
            bsPowodzenieDodaniaDoKoszykaWK.Visible = true;
            bsNiepowodzenieDodaniaDoKoszykaWK.Visible = false;
        }
        else
        {
            bsPowodzenieDodaniaDoKoszykaWK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaWK.Visible = true;
        }
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = true;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaNaglosnienieGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaWyprzedarzyGrid.Visible = true;
        bsTabelaWyprzedarzyGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaWypGrid();
        bsTabelaWyprzedarzyGrid.DataBind();
    }

    protected void bsTabelaInstrumentowGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsTabelaInstrumentowGrid.SelectedIndex;
        bsPolaIK.bsNazwaIK = bsTabelaInstrumentowGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaIK.bsKodIK = bsTabelaInstrumentowGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaIK.bsCenaIK;
        if (float.TryParse(bsTabelaInstrumentowGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena)==true)
            bsPolaIK.bsCenaIK = bs_cena;
        bsCzyDodanoInstrumentDoKoszyka.bsCzyDodanoIK = bs_warstwa_biznesowa.bs_BLDodajIKDoKoszyka(bsPolaIK.bsNazwaIK, bsPolaIK.bsKodIK, bsPolaIK.bsCenaIK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoInstrumentDoKoszyka.bsCzyDodanoIK == true)
        {
            bsPowodzenieDodaniaDoKoszykaIKPnl.Visible = true;
            bsNiepowodzenieDodaniaDoKoszykaIKPnl.Visible = false;
        }
        else
        {
            bsPowodzenieDodaniaDoKoszykaIKPnl.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaIKPnl.Visible = true;
        }
        bsInstrumentyPnl.Visible = true;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaNaglosnienieGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;


        bsTabelaInstrumentowGrid.Visible = true;
        bsTabelaInstrumentowGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleInstrumentowGrid();
        bsTabelaInstrumentowGrid.DataBind();
    }

    protected void bsTabelaNaglosnienieGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsTabelaNaglosnienieGrid.SelectedIndex;
        bsPolaNK.bsNazwaNK = bsTabelaNaglosnienieGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaNK.bsKodNK = bsTabelaNaglosnienieGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaNK.bsCenaNK;
        if (float.TryParse(bsTabelaNaglosnienieGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena) == true)
            bsPolaNK.bsCenaNK = bs_cena;
        bsCzyDodanoProduktNaglasniajacy.bsCzyDodanoPrNagl = bs_warstwa_biznesowa.bs_BLDodajNKDoKoszyka(bsPolaNK.bsNazwaNK, bsPolaNK.bsKodNK, bsPolaNK.bsCenaNK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoProduktNaglasniajacy.bsCzyDodanoPrNagl == true)
        {
            bsPowodzenieDodaniaDoKoszykaNK.Visible = true;
            bsNiepowodzenieDodaniaDoKoszykaNK.Visible = false;
        }
        else
        {
            bsPowodzenieDodaniaDoKoszykaNK.Visible = false;
            bsNiepowodzenieDodaniaDoKoszykaNK.Visible = true;
        }

        bsOprogramowaniePnl.Visible = false;
        bsNaglosnieniePnl.Visible = true;
        bsInstrumentyPnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;


        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaNaglosnienieGrid.Visible = true;
        bsTabelaNaglosnienieGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaNaglosnienieGrid();
        bsTabelaNaglosnienieGrid.DataBind();
    }

    protected void bsOprogramowanieGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsOprogramowanieGrid.SelectedIndex;
        bsPolaOK.bsNazwaOK = bsOprogramowanieGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaOK.bsKodOK = bsOprogramowanieGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaOK.bsCenaOK;
        if (float.TryParse(bsOprogramowanieGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena) == true)
            bsPolaOK.bsCenaOK = bs_cena;
        bsCzyDodanoProgramDoKoszyka.bsCzyDodanoOK = bs_warstwa_biznesowa.bs_BLDodajOKDoKoszyka(bsPolaOK.bsNazwaOK, bsPolaOK.bsKodOK, bsPolaOK.bsCenaOK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoProgramDoKoszyka.bsCzyDodanoOK == true)
        {
            bsPowodzenieOKDodaniaDoKoszykaPnl.Visible = true;
            bsNiepowodzenieOKDodaniaDoKoszykaPnl.Visible = false;
        }
        else
        {
            bsPowodzenieOKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieOKDodaniaDoKoszykaPnl.Visible = true;
        }
        bsOprogramowaniePnl.Visible = true;

        bsAkcesoriaPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsOprogramowanieGrid.Visible = true;
        bsOprogramowanieGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleOprogramowanieGrid();
        bsOprogramowanieGrid.DataBind();
    }

    protected void bsTabelaStudioGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsTabelaStudioGrid.SelectedIndex;
        bsPolaSK.bsNazwaSK = bsTabelaStudioGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaSK.bsKodSK = bsTabelaStudioGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaSK.bsCenaSK;
        if (float.TryParse(bsTabelaStudioGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena) == true)
            bsPolaSK.bsCenaSK = bs_cena;
        bsCzyDodanoStudioDoKoszyka.bsCzyDodanoSK = bs_warstwa_biznesowa.bs_BLDodajSKDoKoszyka(bsPolaSK.bsNazwaSK, bsPolaSK.bsKodSK, bsPolaSK.bsCenaSK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoStudioDoKoszyka.bsCzyDodanoSK == true)
        {
            bsPowodzenieSKDodaniaDoKoszykaPnl.Visible = true;
            bsNiepowodzenieSKDodaniaDoKoszykaPnl.Visible = false;
        }
        else
        {
            bsPowodzenieSKDodaniaDoKoszykaPnl.Visible = false;
            bsNiepowodzenieSKDodaniaDoKoszykaPnl.Visible = true;
        }
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsProcesoryPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;

        bsStudioPnl.Visible = true;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsLogowanieAdminaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;
        bsTabelaDspGrid.Visible = false;

        bsTabelaStudioGrid.Visible = true;
        bsTabelaStudioGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleStGrid();
        bsTabelaStudioGrid.DataBind();
    }

    protected void bsTabelaDspGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        int bs_wybranyIndex = bsTabelaDspGrid.SelectedIndex;
        bsPolaDK.bsNazwaDK = bsTabelaDspGrid.Rows[bs_wybranyIndex].Cells[0].Text;
        bsPolaDK.bsKodDK = bsTabelaDspGrid.Rows[bs_wybranyIndex].Cells[1].Text;
        float bs_cena = bsPolaDK.bsCenaDK;
        if (float.TryParse(bsTabelaDspGrid.Rows[bs_wybranyIndex].Cells[2].Text, out bs_cena) == true)
            bsPolaDK.bsCenaDK = bs_cena;
        bsCzyDodanoDKDoKoszyka.bsCzyDodanoDK = bs_warstwa_biznesowa.bs_BLDodajDK_DoKoszyka(bsPolaDK.bsNazwaDK, bsPolaDK.bsKodDK, bsPolaDK.bsCenaDK, bsKlasaUsera.bsLoginUsera);
        if (bsCzyDodanoDKDoKoszyka.bsCzyDodanoDK == true)
        {

            bsPowodzenieDodaniaDK_DoKoszykaPnl.Visible = true;
            bsNiepowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;
        }
        else
        {
            bsPowodzenieDodaniaDK_DoKoszykaPnl.Visible = false;
            bsNiepowodzenieDodaniaDK_DoKoszykaPnl.Visible = true;
        }
        bsCzolowaZyczeniaPnl.Visible = false;
        bsWyprzedarzPln.Visible = false;
        bsInstrumentyPnl.Visible = false;
        bsNaglosnieniePnl.Visible = false;
        bsAkcesoriaPnl.Visible = false;
        bsOprogramowaniePnl.Visible = false;
        bsStudioPnl.Visible = false;
        bsONasPnl.Visible = false;
        bsKontaktPnl.Visible = false;
        bsFaqPnl.Visible = false;
        bsTransportPnl.Visible = false;
        bsPlatnosciPnl.Visible = false;
        bsTaxFreePnl.Visible = false;
        bsLogowaniePnl.Visible = false;
        bsRejestrowaniePnl.Visible = false;
        bsKomunikatWymaganePolaLogowania.Visible = false;
        bsKomunikatCzyIstniejeTakiUser.Visible = false;
        bsWylogujBtn.Visible = false;
        bsFormaLogowaniaPnl.Visible = false;
        bsFormalarzRejestracjiPnl.Visible = false;
        bsAdmPowodzeniePolaPln.Visible = false;
        bsKomunikatLogowaniaAdminaWymaganePolaPnl.Visible = false;
        bsTabelaAkcesoriowGrid.Visible = false;
        bsTabelaInstrumentowGrid.Visible = false;


        bsProcesoryPnl.Visible = true;
        bsTabelaDspGrid.Visible = false;

        bsTabelaDspGrid.Visible = true;
        bsTabelaDspGrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabelaDspGrid();
        bsTabelaDspGrid.DataBind();

    }
}