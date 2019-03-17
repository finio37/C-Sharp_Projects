using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoDaneProgramu
/// </summary>
public class bsCzyZmodyfikowanoDaneProgramu
{
    private static bool _czyZmodyfikowanoOp;
    public bsCzyZmodyfikowanoDaneProgramu()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyZmodyfikowanoOpAdm { get { return _czyZmodyfikowanoOp; } set { _czyZmodyfikowanoOp = value; } }
}