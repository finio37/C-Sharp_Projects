using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoDsp
/// </summary>
public class bsCzyZmodyfikowanoDsp
{
    private static bool _czyZmodyfDsp;
    public bsCzyZmodyfikowanoDsp()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyZmodyfDsp { get { return _czyZmodyfDsp; } set { _czyZmodyfDsp = value; } }
}