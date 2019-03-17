using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StronaGlowna : System.Web.UI.Page
{
    private BusinesLayer warstwa_biznesowa = new BusinesLayer();
    private string NazwaTowaru;
    private string KodTowaru;
    private double CenaTowaru;
    private bool CzyDodanoTowarDoSklepu;
    private Wlasciwosci wlasc;
    private int NazwaTowaruInt;
    private int KodTowaruInt;
    private double CenaTowaruDouble;
    private bool CzyDodanoProduktDoKoszyka;
    protected void Page_Load(object sender, EventArgs e)
    {
        KomunikatPowodzenia.Visible = false;
        NiepowodzenieDodaniaTowaruDoSklepu.Visible = false;
        ErrorWymagane.Visible = false;
        ErrorPoprawnosci.Visible = false;
        DodanoProduktDoKoszyka.Visible = false;
        NieDodanoProduktuDoKoszyka.Visible = false;
        TabelaTowarowSklepowych.DataSource = warstwa_biznesowa.BLWyswietlTabeleTowarow();
        TabelaTowarowSklepowych.DataBind();
    }

    protected void DodajTowarDoSklepuBtn_Click(object sender, EventArgs e)
    {

        
        if (nazwaTowaruTxb.Text == "" || nazwaTowaruTxb.Text == null || kodTowaruTxb.Text == "" || kodTowaruTxb.Text == null || cenaTowaruTxb.Text == "" || cenaTowaruTxb.Text == null)
        {
            KomunikatPowodzenia.Visible = false;
            NiepowodzenieDodaniaTowaruDoSklepu.Visible = false;
            ErrorWymagane.Visible = true;
            ErrorPoprawnosci.Visible = false;
        }
        else if (int.TryParse(nazwaTowaruTxb.Text, out NazwaTowaruInt) == true || int.TryParse(kodTowaruTxb.Text, out KodTowaruInt) == true || double.TryParse(cenaTowaruTxb.Text, out CenaTowaruDouble) == false)
        {
            KomunikatPowodzenia.Visible = false;
            NiepowodzenieDodaniaTowaruDoSklepu.Visible = false;
            ErrorWymagane.Visible = false;
            ErrorPoprawnosci.Visible = true;
        }
        else
        {
            NazwaTowaru = nazwaTowaruTxb.Text;
            KodTowaru = kodTowaruTxb.Text;
            CenaTowaru = Convert.ToDouble(cenaTowaruTxb.Text);
            CzyDodanoTowarDoSklepu = warstwa_biznesowa.BLDodajRekord(NazwaTowaru, KodTowaru, (float)CenaTowaru);
            if (CzyDodanoTowarDoSklepu == true)
            {
                KomunikatPowodzenia.Visible = true;
                NiepowodzenieDodaniaTowaruDoSklepu.Visible = false;
                ErrorWymagane.Visible = false;
                ErrorPoprawnosci.Visible = false;

            }
            else
            {
                KomunikatPowodzenia.Visible = false;
                NiepowodzenieDodaniaTowaruDoSklepu.Visible = true;
                ErrorWymagane.Visible = false;
                ErrorPoprawnosci.Visible = false;
            }
            TabelaTowarowSklepowych.DataSource = warstwa_biznesowa.BLWyswietlTabeleTowarow();
            TabelaTowarowSklepowych.DataBind();
        }
    }

    protected void TabelaTowarowSklepowych_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ilosc = 1;
        Wlasciwosci wl = new Wlasciwosci();
        int wybranyIndex = TabelaTowarowSklepowych.SelectedIndex;
        
        wl.NazwaTowaru = TabelaTowarowSklepowych.Rows[wybranyIndex].Cells[1].Text;
        wl.KodProduktu = TabelaTowarowSklepowych.Rows[wybranyIndex].Cells[2].Text;
        wl.CenaProduktu = Convert.ToDouble(TabelaTowarowSklepowych.Rows[wybranyIndex].Cells[3].Text);
        CzyDodanoProduktDoKoszyka = warstwa_biznesowa.BLDodajProduktDoKoszyka(wl.NazwaTowaru,wl.KodProduktu,(float)wl.CenaProduktu,ilosc);
        if (CzyDodanoProduktDoKoszyka == true)
        {
            DodanoProduktDoKoszyka.Visible = true;
            NieDodanoProduktuDoKoszyka.Visible = false;

        }
        else
        {
            DodanoProduktDoKoszyka.Visible = false;
            NieDodanoProduktuDoKoszyka.Visible = true;
        }
    }
}