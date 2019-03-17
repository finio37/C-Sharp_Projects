using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaIK
/// </summary>
public class bsPolaIK
{
    private static string _nazwaIK;
    private static string _kodIK;
    private static float _cenaIK;
    public bsPolaIK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwaIK { get { return _nazwaIK; } set { _nazwaIK = value; } }
    public static string bsKodIK { get { return _kodIK; } set { _kodIK = value; } }
    public static float bsCenaIK { get { return _cenaIK; } set { _cenaIK = value; } }
}