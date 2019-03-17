using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_KosztDlugu : System.Web.UI.Page
{
    private bool bsCzyDodanoKosztDlugu;
    private bs_BusinessLayer bs_warstwa_biznesu = new bs_BusinessLayer();
    private double bsKosztDluguWynik;
    protected void Page_Load(object sender, EventArgs e)
    {
        bsErrorWymaganePnl.Visible = false;
        bsErrorPoprawnosciDanych.Visible = false;
        bsErrorMniejszOdZera.Visible = false;
        bsGratulacje.Visible = false;
        bsPrzykroMi.Visible = false;
        bsErrorWiecejNizJeden.Visible = false;
        bsWartoscRynkowaAkcjiHL.Visible = false;
        bsTabelaKosztowDlugu.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleKosztyDlugu();
        bsTabelaKosztowDlugu.DataBind();

    }

    protected void bsObliczKosztKapitaluWlasnegoBtn_Click(object sender, EventArgs e)
    {

    }

    protected void bsKosztDluguBtn_Click(object sender, EventArgs e)
    {
        double bsNStpdouble, bsSOdouble;
        if (bsNominalnaStopaTxb.Text == "" || bsNominalnaStopaTxb.Text == null ||
            bsStawkaOpodatkowaniaTxb.Text == "" || bsStawkaOpodatkowaniaTxb.Text == null)
        {
            bsErrorWymaganePnl.Visible = true;
            bsErrorPoprawnosciDanych.Visible = false;
            bsErrorMniejszOdZera.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsErrorWiecejNizJeden.Visible = false;
            bsTabelaKosztowDlugu.Visible = false;
            bsWartoscRynkowaAkcjiHL.Visible = false;
        }
        else if (double.TryParse(bsNominalnaStopaTxb.Text, out bsNStpdouble) == false ||
            double.TryParse(bsStawkaOpodatkowaniaTxb.Text, out bsSOdouble) == false)
        {
            bsErrorWymaganePnl.Visible = false;
            bsErrorPoprawnosciDanych.Visible = true;
            bsErrorMniejszOdZera.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsErrorWiecejNizJeden.Visible = false;
            bsTabelaKosztowDlugu.Visible = false;
            bsWartoscRynkowaAkcjiHL.Visible = false;
        }
        else
        {
            bsNStpdouble = Convert.ToDouble(bsNominalnaStopaTxb.Text);
            bsSOdouble = Convert.ToDouble(bsStawkaOpodatkowaniaTxb.Text);
            if (bsNStpdouble <= 0 || bsSOdouble <= 0)
            {
                bsErrorWymaganePnl.Visible = false;
                bsErrorPoprawnosciDanych.Visible = false;
                bsErrorMniejszOdZera.Visible = true;
                bsGratulacje.Visible = false;
                bsPrzykroMi.Visible = false;
                bsErrorWiecejNizJeden.Visible =false;
                bsTabelaKosztowDlugu.Visible = false;
                bsWartoscRynkowaAkcjiHL.Visible = false;
            }
            else if (bsSOdouble >= 1 || bsSOdouble >= 1)
            {
                bsErrorWymaganePnl.Visible = false;
                bsErrorPoprawnosciDanych.Visible = false;
                bsErrorMniejszOdZera.Visible = false;
                bsGratulacje.Visible = false;
                bsPrzykroMi.Visible = false;
                bsErrorWiecejNizJeden.Visible = true;
                bsTabelaKosztowDlugu.Visible = false;
                bsWartoscRynkowaAkcjiHL.Visible = false;
            }
            else
            {
                bsErrorWymaganePnl.Visible = false;
                bsErrorPoprawnosciDanych.Visible = false;
                bsErrorMniejszOdZera.Visible = false;
                bsErrorWiecejNizJeden.Visible = false;
                bsTabelaKosztowDlugu.Visible = false;
                bsWartoscRynkowaAkcjiHL.Visible = false;
                bsKosztDluguWynik = bsNStpdouble * (1 - bsSOdouble);
                bsCzyDodanoKosztDlugu = bs_warstwa_biznesu.bs_BLDodajKosztDlugu((float)bsKosztDluguWynik);

                if (bsCzyDodanoKosztDlugu == true)
                {
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsGratulacje.Visible = true;
                    bsTabelaKosztowDlugu.Visible = true;
                    bsTabelaKosztowDlugu.DataSource = bs_warstwa_biznesu.bs_BLWyswietlTabeleKosztyDlugu();
                    bsTabelaKosztowDlugu.DataBind();
                    bsPrzykroMi.Visible = false;
                    bsErrorWiecejNizJeden.Visible = false;
                    bsWartoscRynkowaAkcjiHL.Visible = true;

                }
                else
                {
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsGratulacje.Visible = false;
                    bsPrzykroMi.Visible = true;
                    bsErrorWiecejNizJeden.Visible = false;
                    bsTabelaKosztowDlugu.Visible = false;
                    bsWartoscRynkowaAkcjiHL.Visible = false;

                }
            }
        }
    }
}