using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoProgramDoKoszyka
/// </summary>
public class bsCzyDodanoProgramDoKoszyka
{
    private static bool _czyDodanoOK;
    public bsCzyDodanoProgramDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoOK { get { return _czyDodanoOK; } set { _czyDodanoOK = value; } }
}