using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaWyprzedarzy
/// </summary>
public class bsPolaWyprzedarzy
{
    private static int _idWypCheck;
    private static int _nazwaWypCheck;
    private static int _kodWypCheck;
    private static float _cenaWypCheck;
    public bsPolaWyprzedarzy()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int bsIdWypCheck { get { return _idWypCheck; } set { _idWypCheck = value; } }
    public static int bsNazwaWypCheck { get { return _nazwaWypCheck; } set { _nazwaWypCheck = value; } }
    public static int bsKodWypCheck { get { return _kodWypCheck; } set { _kodWypCheck = value; } }
    public static float bsCenaWypCheck { get { return _cenaWypCheck; } set { _cenaWypCheck = value; } }
}