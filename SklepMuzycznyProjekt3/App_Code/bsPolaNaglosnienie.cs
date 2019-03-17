using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaNaglosnienie
/// </summary>
public class bsPolaNaglosnienie
{
    private static int _bsIdNagl;
    private static int _bsNazwaNaglCheck;
    private static int _bsKodNaglCheck;
    private static float _bsCenaNagl;
    public bsPolaNaglosnienie()
    {
        //
        // TODO: Add constructor logic here
        //

    }
    public static int bsIdNagl { get { return _bsIdNagl; } set { _bsIdNagl = value; } }
    public static int bsNazwaNaglCheck { get { return _bsNazwaNaglCheck; } set { _bsNazwaNaglCheck = value; } }
    public static int bsKodNaglCheck { get { return _bsKodNaglCheck; } set { _bsKodNaglCheck = value; } }
    public static float bsCenaNagl { get { return _bsCenaNagl; } set { _bsCenaNagl = value; } }
}