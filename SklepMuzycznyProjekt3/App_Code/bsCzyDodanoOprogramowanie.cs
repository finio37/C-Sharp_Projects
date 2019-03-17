using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoOprogramowanie
/// </summary>
public class bsCzyDodanoOprogramowanie
{
    private static bool _czyDodanoOp;
    public bsCzyDodanoOprogramowanie()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoAdmOp { get { return _czyDodanoOp; }set { _czyDodanoOp = value; } }
}