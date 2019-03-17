using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bs_KosztKapitalu : System.Web.UI.Page
{
    private double bsKosztKapitalu;
    private bool bsCzyDodanoKosztKapitalu;
    
    private bs_BusinessLayer bs_wartstwa_biznesowa = new bs_BusinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        bsErrorWymaganePnl.Visible = false;
        bsErrorPoprawnosciDanych.Visible = false;
        bsErrorMniejszOdZera.Visible = false;
        bsGratulacje.Visible = false;
        bsPrzykroMi.Visible = false;
        bsTabelaKosztowKapitalu.DataSource = bs_wartstwa_biznesowa.bs_BlWyswietlTablelaKosztowKapitalu();
        bsTabelaKosztowKapitalu.DataBind();
    }

    protected void bsObliczKosztKapitaluWlasnegoBtn_Click(object sender, EventArgs e)
    {
        double bsWRKWdouble,bsWRDdouble,bsKKWdouble,bsKDdouble;

        if (bsWartoscRynkowaKapitaluWlasnegoTxb.Text == "" || bsWartoscRynkowaKapitaluWlasnegoTxb.Text == null ||
            bsWartoscRynkowaDluguTxb.Text == "" || bsWartoscRynkowaDluguTxb.Text == null ||
            bsKosztKapitaluWlasnegoTxb.Text == "" || bsKosztKapitaluWlasnegoTxb.Text == null ||
            bsKosztDluguTxb.Text == "" || bsKosztDluguTxb.Text == null)
        {
            bsErrorWymaganePnl.Visible = true;
            bsErrorPoprawnosciDanych.Visible = false;
            bsErrorMniejszOdZera.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsTabelaKosztowKapitalu.Visible = false;

        }
        else if (double.TryParse(bsWartoscRynkowaKapitaluWlasnegoTxb.Text, out bsWRKWdouble) == false ||
            double.TryParse(bsWartoscRynkowaDluguTxb.Text, out bsWRDdouble) == false ||
            double.TryParse(bsKosztKapitaluWlasnegoTxb.Text, out bsKKWdouble) == false ||
            double.TryParse(bsKosztDluguTxb.Text, out bsKDdouble) == false)
        {
            bsErrorWymaganePnl.Visible = false;
            bsErrorPoprawnosciDanych.Visible = true;
            bsErrorMniejszOdZera.Visible = false;
            bsGratulacje.Visible = false;
            bsPrzykroMi.Visible = false;
            bsTabelaKosztowKapitalu.Visible = false;
        }
        else
        {
            bsWRKWdouble = Convert.ToDouble(bsWartoscRynkowaKapitaluWlasnegoTxb.Text);
            bsWRDdouble = Convert.ToDouble(bsWartoscRynkowaDluguTxb.Text);
            bsKKWdouble = Convert.ToDouble(bsKosztKapitaluWlasnegoTxb.Text);
            bsKDdouble = Convert.ToDouble(bsKosztDluguTxb.Text);
            if (bsWRKWdouble <= 0 || bsWRDdouble <= 0 || bsKKWdouble <= 0 || bsKDdouble <= 0)
            {
                bsErrorWymaganePnl.Visible = false;
                bsErrorPoprawnosciDanych.Visible = false;
                bsErrorMniejszOdZera.Visible = true;
                bsGratulacje.Visible = false;
                bsPrzykroMi.Visible = false;
                bsTabelaKosztowKapitalu.Visible = false;
            }
            else
            {
                bsKosztKapitalu = (bsWRKWdouble * (Math.Pow(bsWRKWdouble + bsWRDdouble, -1))) * bsKKWdouble + (bsWRDdouble * (Math.Pow(bsWRKWdouble + bsWRDdouble, -1))) * bsKDdouble;
                bsCzyDodanoKosztKapitalu = bs_wartstwa_biznesowa.bs_BLDodajKosztKapitalu((float)(bsKosztKapitalu));
                if (bsCzyDodanoKosztKapitalu == true)
                {
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsGratulacje.Visible = true;
                    bsPrzykroMi.Visible = false;
                    bsTabelaKosztowKapitalu.Visible = true;
                    bsTabelaKosztowKapitalu.DataSource = bs_wartstwa_biznesowa.bs_BlWyswietlTablelaKosztowKapitalu();
                    bsTabelaKosztowKapitalu.DataBind();
                    bsKosztDluguHL.Visible = true;
                }
                else
                {
                    bsErrorWymaganePnl.Visible = false;
                    bsErrorPoprawnosciDanych.Visible = false;
                    bsErrorMniejszOdZera.Visible = false;
                    bsGratulacje.Visible = false;
                    bsPrzykroMi.Visible = true;
                    bsTabelaKosztowKapitalu.Visible = false;
                }
            }
        }
    }
}