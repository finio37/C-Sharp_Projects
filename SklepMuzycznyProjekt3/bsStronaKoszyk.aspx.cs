using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bsStronaKoszyk : System.Web.UI.Page
{
    private bsKlasaUsera bs_obiekt_usera = new bsKlasaUsera();
    private bsBusinesLayer bs_warstwa_biznesu = new bsBusinesLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (bsKlasaUsera.bsLoginUsera != null && bsKlasaUsera.bsHasloUsera != null)
        {
            bsNazwaUzytkownikaLbl.Text = bsKlasaUsera.bsLoginUsera;
            string bs_wybrany_user = bsNazwaUzytkownikaLbl.Text;
            
            bsKlasaUsera.bsOtrzymanyUser = bs_warstwa_biznesu.bsBLMetodaZwracajacaSamLogin_I_PobierajacaTylkoLogin(bs_wybrany_user);
            bsTAkcesoriaKoszyk.DataSource = bs_warstwa_biznesu.bs_BLWyswietlAkcesoriaKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTAkcesoriaKoszyk.DataBind();

            bsTabelaInstrumentowKoszyk.DataSource = bs_warstwa_biznesu.bs_BLWyswietlInstrumentyKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaInstrumentowKoszyk.DataBind();

            bsTabelaNaglosnieniaKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlNaglosnienieKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaNaglosnieniaKoszykGrid.DataBind();

            bsTabelaOprogramowaniaKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlOprogramowanieKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaOprogramowaniaKoszykGrid.DataBind();

            bsTabelaProduktowStKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlStudioKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowStKoszykGrid.DataBind();

            bsTabelaProduktowWyprzedarzowychKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlWyprzedarzKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowWyprzedarzowychKoszykGrid.DataBind();

            bsTabelaProduktowDspKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlDspKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowDspKoszykGrid.DataBind();


        }
        else
        {
            bsKlasaUsera.bsOtrzymanyUser = "Nikt";
            bsTAkcesoriaKoszyk.DataSource = bs_warstwa_biznesu.bs_BLWyswietlAkcesoriaKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTAkcesoriaKoszyk.DataBind();

            bsTabelaInstrumentowKoszyk.DataSource = bs_warstwa_biznesu.bs_BLWyswietlInstrumentyKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaInstrumentowKoszyk.DataBind();

            bsTabelaNaglosnieniaKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlNaglosnienieKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaNaglosnieniaKoszykGrid.DataBind();

            bsTabelaOprogramowaniaKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlOprogramowanieKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaOprogramowaniaKoszykGrid.DataBind();

            bsTabelaProduktowStKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlStudioKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowStKoszykGrid.DataBind();

            bsTabelaProduktowWyprzedarzowychKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlWyprzedarzKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowWyprzedarzowychKoszykGrid.DataBind();

            bsTabelaProduktowDspKoszykGrid.DataSource = bs_warstwa_biznesu.bs_BLWyswietlDspKoszyk(bsKlasaUsera.bsOtrzymanyUser);
            bsTabelaProduktowDspKoszykGrid.DataBind();

            
        }
    }

    protected void bsPowrotDoStronyGlownejBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("bs_StronaGlowna.aspx");
    }
}