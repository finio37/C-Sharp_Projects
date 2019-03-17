using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CzyZarejestrowanoPracownika
/// </summary>
public class CzyZarejestrowanoPracownika
{
    private static bool _czyZarPrac;
    public CzyZarejestrowanoPracownika()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool CzyZarPrac { get { return _czyZarPrac; } set { _czyZarPrac = value; } }
}