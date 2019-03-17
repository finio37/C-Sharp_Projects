using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoInstrument
/// </summary>
public class bsCzyZmodyfikowanoInstrument
{
    private static bool _czy_zmodyfikowano_instrument;
    public bsCzyZmodyfikowanoInstrument()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyZmodyfikowanoInstrumentBool { get { return _czy_zmodyfikowano_instrument; }set { _czy_zmodyfikowano_instrument = value; } }
}