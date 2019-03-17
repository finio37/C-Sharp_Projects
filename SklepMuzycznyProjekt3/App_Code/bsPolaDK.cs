using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaDK
/// </summary>
public class bsPolaDK
{
    private static string _nazwaDK;
    private static string _kodDK;
    private static float _cenaDK;
    public bsPolaDK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwaDK { get { return _nazwaDK; }set { _nazwaDK = value; } }
    public static string bsKodDK { get { return _kodDK; } set { _kodDK = value; } }
    public static float bsCenaDK { get { return _cenaDK; } set { _cenaDK = value; } }
}