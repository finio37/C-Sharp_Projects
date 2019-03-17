using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoDoWyprzedarzy
/// </summary>
public class bsCzyDodanoDoWyprzedarzy
{
    private static bool _czyDodWyp;
    public bsCzyDodanoDoWyprzedarzy()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoWyp { get { return _czyDodWyp; } set { _czyDodWyp = value; } }
}