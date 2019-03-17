using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoInstrumentDoKoszyka
/// </summary>
public class bsCzyDodanoInstrumentDoKoszyka
{
    private static bool _bsCzyDodanoIK;
    public bsCzyDodanoInstrumentDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoIK { get { return _bsCzyDodanoIK; } set { _bsCzyDodanoIK = value; } }
}