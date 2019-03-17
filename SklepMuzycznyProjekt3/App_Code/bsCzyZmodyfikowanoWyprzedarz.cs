using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoWyprzedarz
/// </summary>
public class bsCzyZmodyfikowanoWyprzedarz
{
    private static bool _czyZmodWyp;
    public bsCzyZmodyfikowanoWyprzedarz()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyZmodWyp { get { return _czyZmodWyp; } set { _czyZmodWyp = value; } }
}