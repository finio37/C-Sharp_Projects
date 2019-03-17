using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoStudyjne
/// </summary>
public class bsCzyDodanoStudyjne
{
    private static bool _czyDodanoSt;
    public bsCzyDodanoStudyjne()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoSt { get { return _czyDodanoSt; }set { _czyDodanoSt = value; } }
}