using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaSK
/// </summary>
public class bsPolaSK
{
    private static string _nazwaSK;
    private static string _kodSK;
    private static float _cenaSK;
    public bsPolaSK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwaSK { get { return _nazwaSK; } set { _nazwaSK = value; } }
    public static string bsKodSK { get { return _kodSK; } set { _kodSK = value; } }
    public static float bsCenaSK { get { return _cenaSK; } set { _cenaSK = value; } }
}