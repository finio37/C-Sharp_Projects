using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CzyDodanoSzczegoly
/// </summary>
public class CzyDodanoSzczegoly
{
    private static bool _czyDodanoSzcz;
    public CzyDodanoSzczegoly()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool CzyDodanoSzcz { get { return _czyDodanoSzcz; } set { _czyDodanoSzcz = value; } }
}