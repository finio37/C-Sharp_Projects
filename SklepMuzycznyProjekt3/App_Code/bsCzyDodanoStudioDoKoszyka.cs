using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoStudioDoKoszyka
/// </summary>
public class bsCzyDodanoStudioDoKoszyka
{
    private static bool _studioSK;
    public bsCzyDodanoStudioDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoSK { get { return _studioSK; } set { _studioSK = value; } }
}