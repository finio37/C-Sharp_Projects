using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoDsp
/// </summary>
public class bsCzyDodanoDsp
{
    private static bool _czyDodDsp;
    public bsCzyDodanoDsp()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoProduktDsp { get { return _czyDodDsp; } set { _czyDodDsp = value; } }
}