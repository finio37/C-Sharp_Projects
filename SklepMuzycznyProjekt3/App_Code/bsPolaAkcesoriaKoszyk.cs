using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaAkcesoriaKoszyk
/// </summary>
public class bsPolaAkcesoriaKoszyk
{

    private static string _nazwa;
    private static string _kod;
    private static float _cena;
    private static string _login;
    private static float _cenaTemp;
    public bsPolaAkcesoriaKoszyk()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwa { get { return _nazwa; } set { _nazwa = value; } }
    public static string bsKod { get { return _kod; } set { _kod = value; } }
    public static float bsCena { get { return _cena; } set { _cena = value; } }
    public static string bsLogin { get { return _login; } set { _login = value; } }
   public static float bsCenaTemp { get { return _cenaTemp; } set { _cenaTemp = value; } }
}