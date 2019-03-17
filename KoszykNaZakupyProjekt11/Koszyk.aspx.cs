using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Koszyk : System.Web.UI.Page
{
    BusinesLayer warstwa_biznesu = new BusinesLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        tabelaKoszyk.DataSource = warstwa_biznesu.BLWyswietlTabeleKoszyk();
        tabelaKoszyk.DataBind();
    }
}