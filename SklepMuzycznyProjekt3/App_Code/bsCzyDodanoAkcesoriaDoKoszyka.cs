using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoAkcesoriaDoKoszyka
/// </summary>
public class bsCzyDodanoAkcesoriaDoKoszyka
{
    private static bool _bs_czy_dodano_akc_do_koszyka;
    public bsCzyDodanoAkcesoriaDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoAkcDoKoszyka { get { return _bs_czy_dodano_akc_do_koszyka; } set { _bs_czy_dodano_akc_do_koszyka = value; } }
}