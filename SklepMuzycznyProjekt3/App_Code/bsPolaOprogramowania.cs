using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaOprogramowania
/// </summary>
public class bsPolaOprogramowania
{
    private static int _bsIdOp;
    private static int _bsNazwaOpCheck;
    private static int _bsKodOpCheck;
    private static float _bsCenaOpCheck;
    public bsPolaOprogramowania()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int bsIdOP { get { return _bsIdOp; } set { _bsIdOp = value; } }
    public static int bsNazwaOpCheck { get { return _bsNazwaOpCheck; } set { _bsNazwaOpCheck = value; } }
    public static int bsKodOpCheck { get { return _bsKodOpCheck; } set { _bsKodOpCheck = value; } }
    public static float bsCenaOpCheck { get { return _bsCenaOpCheck; } set { _bsCenaOpCheck = value; } }
}