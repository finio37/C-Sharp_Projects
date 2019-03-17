using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoSt
/// </summary>
public class bsCzyZmodyfikowanoSt
{
    private static bool _czyZmodSt;
    public bsCzyZmodyfikowanoSt()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyZmodSt { get { return _czyZmodSt; } set { _czyZmodSt = value; } }
}