using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_WartoscRynkowaAkcji : System.Web.UI.Page
{
    private double bsWartoscRynkowaAkcjiWynik;
    private bool bsCzyDodanoWartoscRynkowaAkcji;
    private bs_BusinessLayer bs_warstwa_biznesowa = new bs_BusinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        bsErrorWymaganePnl.Visible = false;
        bsErrorMniejszOdZera.Visible = false;
        bsErrorPoprawnosciDanych.Visible = false;
        bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = false;
        bsGratulacje.Visible = false;
        bsPrzykroMi.Visible = false;
        
        
    }

    protected void bsObliczWartoscRynkowaAkcji_Click(object sender, EventArgs e)
    {
        double bsDywidendaDouble, bsStopaWzrostuDywidendyDouble, bsKosztKapWlasnDouble;
       
        if (bsDywidendaTxb.Text == "" || bsDywidendaTxb.Text == null || bsStopaWzrostuDywidendyTxb.Text == "" || bsStopaWzrostuDywidendyTxb.Text == null ||
            bsKosztKapitaluWlasnegoTxb.Text == "" || bsKosztKapitaluWlasnegoTxb.Text == null)
        {
            bsErrorWymaganePnl.Visible = true;
            bsErrorPoprawnosciDanych.Visible = false;
            bsErrorMniejszOdZera.Visible = false;
            bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsTabelaWRAgrid.Visible = false;
        }
        else if (double.TryParse(bsDywidendaTxb.Text, out bsDywidendaDouble) == false ||
            double.TryParse(bsStopaWzrostuDywidendyTxb.Text, out bsStopaWzrostuDywidendyDouble) == false ||
            double.TryParse(bsKosztKapitaluWlasnegoTxb.Text, out bsKosztKapWlasnDouble)==false)
        {
            bsErrorPoprawnosciDanych.Visible = true;
            bsErrorWymaganePnl.Visible = false;
            bsErrorMniejszOdZera.Visible = false;
            bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsTabelaWRAgrid.Visible = false;
        }
        else
        {
            bsDywidendaDouble = Convert.ToDouble(bsDywidendaTxb.Text);
            bsStopaWzrostuDywidendyDouble = Convert.ToDouble(bsStopaWzrostuDywidendyTxb.Text);
            bsKosztKapWlasnDouble = Convert.ToDouble(bsKosztKapitaluWlasnegoTxb.Text);
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsTabelaWRAgrid.Visible = false;
            if (bsStopaWzrostuDywidendyDouble > bsKosztKapWlasnDouble)
            {
                bsErrorPoprawnosciDanych.Visible = false;
                bsErrorWymaganePnl.Visible = false;
                bsErrorMniejszOdZera.Visible = false;
                bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = true;
                bsGratulacje.Visible = false;
                bsPrzykroMi.Visible = false;
                bsTabelaWRAgrid.Visible = false;
            }
            else
            {
                bsWartoscRynkowaAkcjiWynik = bsDywidendaDouble * (1 + bsStopaWzrostuDywidendyDouble) * Math.Pow(bsKosztKapWlasnDouble - bsStopaWzrostuDywidendyDouble, -1);
                bsCzyDodanoWartoscRynkowaAkcji = bs_warstwa_biznesowa.bs_BLDodajWartoscRynkowoAkcji((float)bsWartoscRynkowaAkcjiWynik);
                if (bsCzyDodanoWartoscRynkowaAkcji == true)
                {
                    bsGratulacje.Visible = true;
                    bsPrzykroMi.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = false;
                    bsTabelaWRAgrid.Visible = true;
                    bsTabelaWRAgrid.DataSource = bs_warstwa_biznesowa.bs_BLWyswietlTabeleWartoscRynkoweAkcji();
                    bsTabelaWRAgrid.DataBind();
                }
                else
                {
                    bsPrzykroMi.Visible = true;
                    bsGratulacje.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsErrorStopaWzrostuMniejszaOdKosztuWlasnego.Visible = false;
                    bsTabelaWRAgrid.Visible = false;
                }
            }
        }
    }
}