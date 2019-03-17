using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaWK
/// </summary>
public class bsPolaWK
{
    private static int _idWK;
    private static string _nazwaWK;
    private static string _kodWK;
    private static float _cenaWK;
    //private static string _loginWK;
    public bsPolaWK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int bsIdWK { get { return _idWK; }set { _idWK = value; } }
    public static string bsNazwaWK { get { return _nazwaWK; } set { _nazwaWK = value; } }
    public static string bsKodWK { get { return _kodWK; } set { _kodWK = value; } }
    public static float bsCenaWK { get { return _cenaWK; } set { _cenaWK = value; } }
   
}