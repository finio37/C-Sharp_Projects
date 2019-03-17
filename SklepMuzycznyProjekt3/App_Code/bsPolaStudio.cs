using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaStudio
/// </summary>
public class bsPolaStudio
{
    private static int _bsIdSt;
    private static int _bsNazwaSt;
    private static int _bsKodSt;
    private static float _bsCenaSt;
    public bsPolaStudio()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int bsIdSt { get { return _bsIdSt; }set { _bsIdSt = value; } }
    public static int bsNazwaSt { get { return _bsNazwaSt; } set { _bsNazwaSt = value; } }
    public static int bsKodSt { get { return _bsKodSt; } set { _bsKodSt = value; } }
    public static float bsCenaSt { get { return _bsCenaSt; } set { _bsCenaSt = value; } }
}