using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyZmodyfikowanoNaglosnienie
/// </summary>
public class bsCzyZmodyfikowanoNaglosnienie
{
    private static bool _czyZmod;
    public bsCzyZmodyfikowanoNaglosnienie()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool CzyZmodNaglosnienie { get { return _czyZmod; } set { _czyZmod = value; } }
}