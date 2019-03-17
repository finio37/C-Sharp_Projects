using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaOK
/// </summary>
public class bsPolaOK
{
    private static string _nazwaOK;
    private static string _kodOK;
    private static float _cenaOK;
    public bsPolaOK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwaOK { get { return _nazwaOK; } set { _nazwaOK = value; } }
    public static string bsKodOK { get { return _kodOK; } set { _kodOK = value; } }
    public static float bsCenaOK { get { return _cenaOK; } set { _cenaOK = value; } }
}