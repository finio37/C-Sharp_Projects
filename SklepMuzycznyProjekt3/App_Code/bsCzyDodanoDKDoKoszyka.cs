using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoDKDoKoszyka
/// </summary>
public class bsCzyDodanoDKDoKoszyka
{
    private static bool _czyDodanoDK;
    public bsCzyDodanoDKDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoDK { get { return _czyDodanoDK; }set { _czyDodanoDK = value; } }
}