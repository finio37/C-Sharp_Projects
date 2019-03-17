using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaDsp
/// </summary>
public class bsPolaDsp
{
    private static int _bsIdDsp;
    private static int _bsNazwaDsp;
    private static int _bsKodDsp;
    private static float _bsCenaDsp;
    public bsPolaDsp()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int bsIdDsp { get { return _bsIdDsp; }set { _bsIdDsp = value; } }
    public static int bsNazwaDsp { get { return _bsNazwaDsp; } set { _bsNazwaDsp = value; } }
    public static int bsKodDsp { get { return _bsKodDsp; } set { _bsKodDsp = value; } }
    public static float bsCenaDsp { get { return _bsCenaDsp; } set { _bsCenaDsp = value; } }
}